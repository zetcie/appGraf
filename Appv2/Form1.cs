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
using AForge.Video.FFMPEG;

namespace Appv2
{
    public partial class form1 : Form
    {

        string fileContent = string.Empty;
        string filePath = string.Empty;
        Image zmienna = new Bitmap("C:/Users/Nati/Desktop/Nowy folder/appGraf/znaki/zielony.png");
        int posX = 0;
        int posY = -10;
        int pos2Y = 413;
        PointF ulCorner = new PointF(10.0F, 10.0F);
        FileVideoSource videoSource = new FileVideoSource();//@"C:\Users\Zosienka\Desktop\semestr6\GiM\GiM-master\film1.avi");

        //string text = System.IO.File.ReadAllText(@"C:\Users\Zosienka\Desktop\zosia.txt");

        public form1()
        {
            InitializeComponent();
        }

        //start filmu
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                videoSource.Start();
                videoSourcePlayer1.VideoSource = videoSource;
            }
            catch (FileNotFoundException) { MessageBox.Show("Nie załadowano filmu."); }
        }

        //ładowanie
        public void button5_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.CheckFileExists = true;
                openFileDialog.CheckPathExists = true;
                openFileDialog.DefaultExt = "avi";
                openFileDialog.Filter = "avi files (*.avi)|*.avi";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    videoSource = new FileVideoSource(openFileDialog.FileName);
                    videoSource.Start();
                    videoSourcePlayer1.VideoSource = videoSource;
                    videoSourcePlayer1.Width = 780;//skalowanie
                    videoSourcePlayer1.Height = 370;

                }
            }
            catch (FileLoadException)
            {
                Console.Write("Nie załadowano pliku.");
                MessageBox.Show("Nie załadowano filmu.");
            }
            catch (FormatException)
            {
                MessageBox.Show("Nie załadowano filmu.");
            }
            
        }
        

        public void video_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            //PointF ulCorner = new PointF(250, videoSourcePlayer1.Height-350);
            Bitmap bitmap = eventArgs.Frame;
            Graphics graphics = Graphics.FromImage(bitmap);
            graphics.DrawImage(SetImageOpacity(zmienna, 0.5f), ulCorner); //znak wodny
           
        }

        public void video_NewFrame2(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap = eventArgs.Frame;
            Graphics graphics = Graphics.FromImage(bitmap);
            SolidBrush alphaBrush = new SolidBrush(Color.FromArgb(128, 255, 255, 255));
            Font f = new Font(FontFamily.GenericSerif, 40.0f, FontStyle.Bold);
            //graphics.DrawString(text, f, alphaBrush, posX, pos2Y);//napis z pliku

            graphics.DrawString(textBox1.Text, f, alphaBrush, posX, pos2Y);//napis


        }

        //latanie tekstu
        private void timer1_Tick(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height, PixelFormat.Format32bppArgb);
            Graphics graphics = Graphics.FromImage(bmp);

            //Rectangle rect = new Rectangle(pictureBox1.Width, pictureBox1.Height, pictureBox1.Width, pictureBox1.Height);
            Font f = new Font(FontFamily.GenericSerif, 30.0f, FontStyle.Bold);

            //graphics.FillRectangle(Brushes.Black, rect);

            SolidBrush alphaBrush = new SolidBrush(Color.FromArgb(90, 255, 0, 0));

            //graphics.DrawString("Ala ma kota", f, alphaBrush, posX, posY);
            graphics.DrawString(textBox1.Text, f, alphaBrush, posX, posY);

            posX += 20;


            if (posX > this.pictureBox1.Width)
            {
                posX = -this.pictureBox1.Width;
            }

            this.pictureBox1.Image = bmp;
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
            try
            {
                ComboBox senderComboBox = (ComboBox)sender;
                int selectedIndex = comboBox1.SelectedIndex;
                Object selectedItem = comboBox1.SelectedItem;

                if (selectedIndex.Equals(0))
                {
                    zmienna = new Bitmap("C:/Users/Nati/Desktop/Nowy folder/appGraf/znaki/zielony.png");
                }
                else if (selectedIndex.Equals(1))
                {
                    zmienna = new Bitmap("C:/Users/Nati/Desktop/Nowy folder/appGraf/znaki/zolty.png");
                }
                else if (selectedIndex.Equals(2))
                {
                    zmienna = new Bitmap("C:/Users/Nati/Desktop/Nowy folder/appGraf/znaki/pomaranczowy.png");
                }
                else if (selectedIndex.Equals(3))
                {
                    zmienna = new Bitmap("C:/Users/Nati/Desktop/Nowy folder/appGraf/znaki/czerwony.png");
                }
            }
            catch (FileNotFoundException) {
                MessageBox.Show("Nie załadowano filmu.");
            }
        }

        //dodanie znaku wodnego
        public void button2_Click(object sender, EventArgs e)
        {
            try
            {
                videoSource.NewFrame += new NewFrameEventHandler(video_NewFrame);
                videoSourcePlayer1.VideoSource = videoSource;
            }
            catch (FileNotFoundException) { MessageBox.Show("Nie załadowano filmu."); }
        }

        //usuniecie znaku wodnego
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                videoSource.NewFrame -= new NewFrameEventHandler(video_NewFrame);
                videoSourcePlayer1.VideoSource = videoSource;
            }
            catch (FileNotFoundException) { MessageBox.Show("Nie załadowano filmu."); }
        }

        //stop filmu
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                videoSource.Stop();
                videoSourcePlayer1.VideoSource = videoSource;
            }
            catch (FileNotFoundException) { MessageBox.Show("Nie załadowano filmu."); }
        }

        //dodanie napisu
        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                videoSource.NewFrame += new NewFrameEventHandler(video_NewFrame2);
                videoSourcePlayer1.VideoSource = videoSource;
            }
            catch (FileNotFoundException) { MessageBox.Show("Nie załadowano filmu."); }
        }

        //usuniecie napisu
        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                videoSource.NewFrame -= new NewFrameEventHandler(video_NewFrame2);
                videoSourcePlayer1.VideoSource = videoSource;
            }
            catch(FileNotFoundException) { MessageBox.Show("Nie załadowano filmu."); }
        }
        
    }

}
