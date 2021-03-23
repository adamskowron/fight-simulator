using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge;
using AForge.Video;
using AForge.Video.DirectShow;
using AForge.Imaging;
using AForge.Imaging.Filters;
using AForge.Video.FFMPEG;

namespace WindowsFormsApp1
{
    public partial class FormMain : Form
    {
        private FilterInfoCollection captureDevice;
        private VideoCaptureDevice finalFrame;
        private ContrastCorrection contrast;
        private int valueOfContrast;
        private Invert negative;
        private BrightnessCorrection brightness;
        private int valueOfBrightness;
        private VideoFileWriter toWrite;

        public FormMain()
        {
            InitializeComponent();

            pictureBox.Height = 400;
            pictureBox.Width = 320;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            captureDevice = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo device in captureDevice)
            {
                comboBox.Items.Add(device.Name);
            }
            comboBox.SelectedIndex = 0;
            finalFrame = new VideoCaptureDevice();
            toWrite = new VideoFileWriter();

            finalFrame = new VideoCaptureDevice(captureDevice[comboBox.SelectedIndex].MonikerString);
            finalFrame.NewFrame += new NewFrameEventHandler(finalFrame_NewFrame);
            finalFrame.Start();
        }

       

        private void finalFrame_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            
            pictureBox.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (finalFrame.IsRunning == true)
            {
                finalFrame.Stop();
            }
        }

        private void buttonPhoto_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = (Bitmap)pictureBox.Image.Clone();
        }

        private void buttonContrast_Click(object sender, EventArgs e)
        {
            int valueOfContrast = 0;
            if(int.TryParse(textBoxContrast.Text, out valueOfContrast) )
            {
                contrast = new ContrastCorrection(valueOfContrast);
                pictureBox2.Image = (Bitmap)pictureBox.Image.Clone();
                contrast.ApplyInPlace((Bitmap)pictureBox2.Image);
            }else
            {
                textBoxContrast.Text = "You must place here number";
            }
        }

        private void buttonNegative_Click(object sender, EventArgs e)
        {
            negative = new Invert();
            pictureBox2.Image = (Bitmap)pictureBox.Image.Clone();
            negative.ApplyInPlace((Bitmap)pictureBox2.Image);
        }

        private void buttonBrightness_Click(object sender, EventArgs e)
        {
            int valueOfBrightness = 0;
            if (int.TryParse(textBoxBrightness.Text, out valueOfBrightness))
            {
             //   valueOfBrightness = Int32.Parse(textBoxBrightness.Text);
                brightness = new BrightnessCorrection(valueOfBrightness);
                pictureBox2.Image = (Bitmap)pictureBox.Image.Clone();
                brightness.ApplyInPlace((Bitmap)pictureBox2.Image);
            }
            else
            {
                textBoxBrightness.Text = "You must place here number";
            }
        }

        private void buttonSaveToFile_Click(object sender, EventArgs e)
        {
            Bitmap bitmap = (Bitmap)pictureBox2.Image;
            string source = Environment.CurrentDirectory;
            string name = System.IO.Path.Combine(source, @"photo.bmp");
            bitmap.Save(name);
        }
        private void buttonStartRecording_Click(object sender, EventArgs e)
        {
            toWrite.Open("movie.avi", 320, 240, 25, VideoCodec.MPEG4);
            for (int i = 0; i < 1000; i++)
            {
                ((Bitmap)pictureBox.Image).SetPixel(i % pictureBox.Width, i % pictureBox.Height, Color.Red);
                toWrite.WriteVideoFrame((Bitmap)pictureBox.Image);
            }
        }

        private void buttonStopRecording_Click(object sender, EventArgs e)
        {
            toWrite.Close();
        }

    }
}
