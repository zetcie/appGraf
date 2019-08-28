using AForge.Video;
using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;

namespace Appv2
{
    public partial class Form1 : Form
    {

        string fileContent = string.Empty;
        string filePath = string.Empty;
        Image zmienna = new Bitmap("C:/Users/Zosienka/Desktop/semestr6/GiM/znaki/zielony.png");
        PointF ulCorner = new PointF(550.0F, 25.0F);
        //private static string zmienna;
        FileVideoSource videoSource = new FileVideoSource();//@"C:\Users\Zosienka\Desktop\semestr6\GiM\GiM-master\film1.avi");
        

        public Form1()
        {
            InitializeComponent();
        }

        //start filmu
        private void button1_Click(object sender, EventArgs e)
        {
           videoSource.Start();
           videoSourcePlayer1.VideoSource = videoSource;
        }

        //ładowanie
        public void button5_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "avi files (*.avi)|*.avi|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                videoSource = new FileVideoSource(openFileDialog.FileName);
                videoSource.Start();
                videoSourcePlayer1.VideoSource = videoSource;

            }
        }
        

        public void video_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap = eventArgs.Frame;
            Graphics graphics = Graphics.FromImage(bitmap);
            graphics.DrawImage(SetImageOpacity(zmienna, 0.5f), ulCorner); //znak wodny

            /*SolidBrush alphaBrush = new SolidBrush(Color.FromArgb(128, 255, 0, 0));
            Font f = new Font(FontFamily.GenericSerif, 30.0f, FontStyle.Bold);
            
            graphics.DrawString("chuj", f, alphaBrush, 50, 50);//napis*/
        }

        public Image SetImageOpacity(Image image, float opacity)
        {
            Bitmap bmp = new Bitmap(80, 80);
            using (Graphics gfx = Graphics.FromImage(bmp))
            {
                ColorMatrix matrix = new ColorMatrix();

                matrix.Matrix33 = opacity;

                ImageAttributes attributes = new ImageAttributes();

                attributes.SetColorMatrix(matrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

                gfx.DrawImage(image, new Rectangle(0, 0, bmp.Width, bmp.Height), 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, attributes);
            }
            return bmp;
        }   



        public void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {

            ComboBox senderComboBox = (ComboBox)sender;
            int selectedIndex = comboBox1.SelectedIndex;
            Object selectedItem = comboBox1.SelectedItem;

            if(selectedIndex.Equals(0))
            {                
                zmienna = new Bitmap("C:/Users/Zosienka/Desktop/semestr6/GiM/znaki/zielony.png");
            }
            else if(selectedIndex.Equals(1))
            {
                zmienna = new Bitmap("C:/Users/Zosienka/Desktop/semestr6/GiM/znaki/zolty.png");
            }
            else if (selectedIndex.Equals(2))
            {
                zmienna = new Bitmap("C:/Users/Zosienka/Desktop/semestr6/GiM/znaki/pomaranczowy.png");
            }
            else if (selectedIndex.Equals(3))
            {
                zmienna = new Bitmap("C:/Users/Zosienka/Desktop/semestr6/GiM/znaki/czerwony.png");
            }

        }
        public void button2_Click(object sender, EventArgs e)
        {
            videoSource.NewFrame += new NewFrameEventHandler(video_NewFrame);

            videoSourcePlayer1.VideoSource = videoSource;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            videoSource.NewFrame -= new NewFrameEventHandler(video_NewFrame);
            videoSourcePlayer1.VideoSource = videoSource;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            videoSource.Stop();
            videoSourcePlayer1.VideoSource = videoSource;
        }

    
    }

}
