using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace BlackAndWhiteConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bitmap pic = new Bitmap(pictureBox1.Image);
            Bitmap newPic = new Bitmap(pic);
            Color pixelColor = new Color();
            for (int x = 0; x < pic.Width; x++)
            {
                for (int y = 0; y < pic.Height; y++)
                {
                    pixelColor = pic.GetPixel(x, y);
                    if ((pixelColor.R > 0 & pixelColor.R < 128) | (pixelColor.G > 0 & pixelColor.G < 128) | (pixelColor.B > 0 & pixelColor.B < 128))
                        newPic.SetPixel(x, y, Color.Black);
                    else
                        newPic.SetPixel(x, y, Color.White);
                }
            }
            pictureBox1.Image = newPic;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            Bitmap openedPic = new Bitmap(openFileDialog1.OpenFile());
            pictureBox1.Image = openedPic;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
