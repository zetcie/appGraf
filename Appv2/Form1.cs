using AForge.Video;
using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace Appv2
{
    public partial class form1 : Form
    {
        static string projectFolder = "..\\..\\";

        Image zmienna = new Bitmap(projectFolder + @"signs\zielony.png");
        FileVideoSource videoSource = new FileVideoSource();
        PointF ulCorner = new PointF(10.0F, 10.0F);
        int posX = 0;
        int pos2X = 0;
        float pos2Y = 0;

        string text = "";
        List<string> text2 = new List<string>();

        public form1()
        {
            InitializeComponent();
        }

        //ładowanie
        public void loadVideo_Click(object sender, EventArgs e)
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
                    //videoSourcePlayer1.Width = ClientSize.Width ;// 780;//skalowanie
                    //videoSourcePlayer1.Height = ClientSize.Height;// 370;
                    pos2Y = ClientSize.Height;

                }
            }
            catch (FileLoadException)
            {
                MessageBox.Show("Nie załadowano filmu.");
            }

        }

        //start filmu
        private void playVideo_Click(object sender, EventArgs e)
        {
            try
            {
                videoSource.Start();
                videoSourcePlayer1.VideoSource = videoSource;
            }
            catch (Exception) { MessageBox.Show("Nie załadowano filmu."); }
        }

        //stop filmu
        private void stopVideo_Click(object sender, EventArgs e)
        {
            if (videoSource.IsRunning)
            {
                videoSource.Stop();
                videoSourcePlayer1.VideoSource = videoSource;
            }
            else
            {
                MessageBox.Show("Nie załadowano filmu.");
            }
        }


        public void video_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
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
            graphics.DrawString(String.Join(" ", text2), f, alphaBrush, pos2X, pos2Y);//napis z pliku
        }

        //latanie tekstu
        private void timer1_Tick(object sender, EventArgs e)
        {


            posX += 20;
            pos2X -= 20;

            if (posX > this.ClientSize.Width || pos2X > this.ClientSize.Width)
            {
                posX = -this.ClientSize.Width;
                pos2X = +this.ClientSize.Width;
            }
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

        public void listOfSigns_SelectionChangeCommitted(object sender, EventArgs e)
        {

            ComboBox senderComboBox = (ComboBox)sender;
            int selectedIndex = listOfSigns.SelectedIndex;
            Object selectedItem = listOfSigns.SelectedItem;

            if (selectedIndex.Equals(0))
            {
                zmienna = new Bitmap(projectFolder + @"signs/zielony.png");
            }
            else if (selectedIndex.Equals(1))
            {
                zmienna = new Bitmap(projectFolder + @"signs/zolty.png");
            }
            else if (selectedIndex.Equals(2))
            {
                zmienna = new Bitmap(projectFolder + @"signs/pomaranczowy.png");
            }
            else if (selectedIndex.Equals(3))
            {
                zmienna = new Bitmap(projectFolder + @"signs/czerwony.png");
            }
        }

        //dodanie znaku wodnego
        public void addSign_Click(object sender, EventArgs e)
        {
            if (videoSource.IsRunning)
            {
                videoSource.NewFrame += new NewFrameEventHandler(video_NewFrame);
                videoSourcePlayer1.VideoSource = videoSource;
            }
            else
            {
                MessageBox.Show("Nie załadowano filmu.");
            }
        }

        //usuniecie znaku wodnego
        private void deleteSign_Click(object sender, EventArgs e)
        {

            if (videoSource.IsRunning)
            {
                videoSource.NewFrame -= new NewFrameEventHandler(video_NewFrame);
                videoSourcePlayer1.VideoSource = videoSource;
            }
            else
            {
                MessageBox.Show("Nie załadowano filmu.");
            }
        }
        
        //dodanie napisu
        private void addText_Click(object sender, EventArgs e)
        {
            if (videoSource.IsRunning)
            {
                videoSource.NewFrame += new NewFrameEventHandler(video_NewFrame2);
                videoSourcePlayer1.VideoSource = videoSource;
            }
            else
            {
                MessageBox.Show("Nie załadowano filmu.");
            }
        }

        //usuniecie napisu
        private void deleteText_Click(object sender, EventArgs e)
        {
            if (videoSource.IsRunning)
            {
                videoSource.NewFrame -= new NewFrameEventHandler(video_NewFrame2);
                videoSourcePlayer1.VideoSource = videoSource;
            }
            else
            {
                MessageBox.Show("Nie załadowano filmu.");
            }
        }

        private void loadText_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog2 = new OpenFileDialog();
            openFileDialog2.InitialDirectory = "c:\\";
            openFileDialog2.CheckFileExists = true;
            openFileDialog2.CheckPathExists = true;
            openFileDialog2.DefaultExt = "txt";
            openFileDialog2.Filter = "txt files (*.txt)|*.txt";
            openFileDialog2.FilterIndex = 2;
            openFileDialog2.RestoreDirectory = true;

            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openFileDialog2.FileName);
                while (text != null)
                {
                    text = sr.ReadLine();
                    if (text != null)
                    {
                        text2.Add(text);

                        
                    }
                }
                sr.Close();
                videoSource.NewFrame += new NewFrameEventHandler(video_NewFrame2);
                videoSourcePlayer1.VideoSource = videoSource;
            }
        }

        private void form1_Load(object sender, EventArgs e)
        {

        }

    }
}
