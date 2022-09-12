using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageProcess1
{
    public partial class Form1 : Form
    {
        private int Clamp(int value, int min, int max)
        {
            if(value < min)
            {
                return min;
            }
            if(value > max)
            {
                return max;
            }
            return value;
        }
        Bitmap image;
        public Form1()
        {
            InitializeComponent();
        }

        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image files|*.png;*.jpg;*.bmp|All files(*.*|*.*)";
            if(dialog.ShowDialog()==DialogResult.OK)
            {
                image = new Bitmap(dialog.FileName);
                pictureBox1.Image = image;
                pictureBox1.Refresh();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void серыйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int height = image.Height;
            int weight = image.Width;
            int mid = 0;
            Bitmap tempBitmap = new Bitmap(image.Width, image.Height);
            for (int i = 0; i<height; i++)
            {
                for(int j = 0; j<weight; j++)
                {
                    mid = Clamp((int)((float)image.GetPixel(j, i).R * 0.33f + (float)image.GetPixel(j, i).G * 0.33f + (float)image.GetPixel(j, i).B * 0.33f), 0, 255);
                    tempBitmap.SetPixel(j, i, Color.FromArgb(mid, mid, mid));
                }
            }
            image = tempBitmap;
            pictureBox1.Image = tempBitmap;
            pictureBox1.Refresh();
        }

        private void блюрToolStripMenuItem_Click(object sender, EventArgs e)
        {
            float[,] kernel = new float[3,3];
            for (int i =0; i<3; i++)
            {
                for(int j=0; j<3;j++)
                {
                    kernel[i, j] = 0.111111111111111f;
                }
            }
            Bitmap tempBitmap = new Bitmap(image.Width, image.Height);
            for (int i = 0; i< image.Width; i++)
            {
                for (int j = 0;j< image.Height; j++)
                {

                    float resR = 0;
                    float resG = 0;
                    float resB = 0;
                    for (int l = -3/2; l<=3/2; l++)
                    {
                        for (int k = -3 / 2; k <= 3 / 2; k++)
                        {
                            int idX = Clamp(i + l, 0, image.Width-1);
                            int idY = Clamp(j + k, 0, image.Height-1);
                            Color nearColor = image.GetPixel(idX, idY);
                            resR += nearColor.R * kernel[k + 3 / 2, l + 3 / 2];
                            resG += nearColor.G * kernel[k + 3 / 2, l + 3 / 2];
                            resB += nearColor.B * kernel[k + 3 / 2, l + 3 / 2];
                        }
                    }
                    tempBitmap.SetPixel(i, j, Color.FromArgb((int)resR, (int)resG, (int)resB));
                }
            }
            image = tempBitmap;
            pictureBox1.Image = tempBitmap;
            pictureBox1.Refresh();
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                image.Save(dialog.FileName);
            }

        }
    }
}
