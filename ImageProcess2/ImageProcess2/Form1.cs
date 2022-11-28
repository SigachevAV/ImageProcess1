using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ImageProcess2;
using Noise;


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
            ToGray();
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

        private void растягиваниеГистограмыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int minR = image.GetPixel(0, 0).R;
            int minG = image.GetPixel(0, 0).G;
            int minB = image.GetPixel(0, 0).B;
            int maxR = image.GetPixel(0, 0).R;
            int maxG = image.GetPixel(0, 0).G;
            int maxB = image.GetPixel(0, 0).B;
            for(int i =0; i<image.Width; i++)
            {
                for(int j = 0; j<image.Height; j++)
                {
                    int tempR = image.GetPixel(i, j).R;
                    int tempG = image.GetPixel(i, j).G;
                    int tempB = image.GetPixel(i, j).B;
                    if (tempR < minR)
                    {
                        minR = tempR;
                    }
                    if (tempG < minG)
                    {
                        minG = tempG;
                    }
                    if (tempB < minB)
                    {
                        minB = tempB;
                    }
                    if (tempR > maxR)
                    {
                        maxR = tempR;
                    }
                    if (tempG > maxG)
                    {
                        maxG = tempG;
                    }
                    if (tempB > maxB)
                    {
                        maxB = tempB;
                    }
                }
            }
            Bitmap tempBitmap = new Bitmap(image.Width, image.Height);
            for (int i = 0; i < image.Width; i++)
            {
                for (int j = 0; j < image.Height; j++)
                {
                    Color temp = image.GetPixel(i, j);
                    tempBitmap.SetPixel(i, j, Color.FromArgb((int)((temp.R - minR) * 255.0 / (maxR - minR)), (int)((temp.G - minG) * 255.0 / (maxG - minG)), (int)((temp.B - minB) * 255.0 / (maxB - minB))));
                }
            }
            image = tempBitmap;
            pictureBox1.Image = tempBitmap;
            pictureBox1.Refresh();
        }

        private void ToGray()
        {
            int height = image.Height;
            int weight = image.Width;
            int mid = 0;
            Bitmap tempBitmap = new Bitmap(image.Width, image.Height);
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < weight; j++)
                {
                    mid = Clamp((int)((float)image.GetPixel(j, i).R * 0.33f + (float)image.GetPixel(j, i).G * 0.33f + (float)image.GetPixel(j, i).B * 0.33f), 0, 255);
                    tempBitmap.SetPixel(j, i, Color.FromArgb(mid, mid, mid));
                }
            }
            image = tempBitmap;
            pictureBox1.Image = tempBitmap;
            pictureBox1.Refresh();
        }
        private void пороговаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToGray();
            Bitmap tempBitmap = new Bitmap(image.Width, image.Height);
            for (int i = 0; i<image.Width; i++)
            {
                for(int j = 0; j<image.Height; j++)
                {
                    if(image.GetPixel(i, j).R < 127)
                    {
                        tempBitmap.SetPixel(i, j, Color.FromArgb(0, 0, 0));
                    }
                    else
                    {
                        tempBitmap.SetPixel(i, j, Color.FromArgb(255, 255, 255));
                    }
                }
            }
            image = tempBitmap;
            pictureBox1.Image = tempBitmap;
            pictureBox1.Refresh();
        }

        private void ниблэкToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToGray();
            Bitmap tempBitmap = new Bitmap(image.Width, image.Height);
            for (int i = 0; i<image.Width; i++)
            {
                for(int j = 0; j<image.Height; j++)
                {
                    int n = 20;
                    int mid = 0;
                    float midS = 0;
                    for (int l = -n/2; l<n/2; l++)
                    {
                        for(int k = -n/2; k<n/2; k++)
                        {
                            if ((0 < i + l) || (i + l < image.Width) || (0 < j + k) || (j + k < image.Height))
                            {
                                continue;
                            }
                            Color nearColor = image.GetPixel(i+l, j+k);
                            mid += nearColor.R;
                        }
                    }
                    mid = mid  / (n * n);
                    for (int l = -n / 2; l < n / 2; l++)
                    {
                        for(int k = -n / 2; k < n / 2; k++)
                        {
                            if ((0 < i + l) || (i + l < image.Width) || (0 < j + k) || (j + k < image.Height))
                            {
                                continue;
                            }
                            Color nearColor = image.GetPixel(i + l, j + k);
                            midS += (float)Math.Pow(nearColor.R, 2);
                        }
                    }
                    midS = (float)Math.Sqrt(midS / (n*n) - mid*mid);
                    if(image.GetPixel(i, j).R < (int)(mid-0.2f*midS))
                    {
                        tempBitmap.SetPixel(i, j, Color.FromArgb(0, 0, 0));
                    }
                    else
                    {
                        tempBitmap.SetPixel(i, j, Color.FromArgb(255, 255, 255));
                    }
                }
            }
            image = tempBitmap;
            pictureBox1.Image = tempBitmap;
            pictureBox1.Refresh();
        }

        private void гистограмнаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToGray();
            int[] gist = new int[256];
            for(int i = 0; i<256; i++)
            {
                gist[i] = 0;
            }
            for(int i = 0; i<image.Width; i++)
            {
                for(int j =0; j<image.Height; j++)
                {
                    gist[image.GetPixel(i, j).R]++;
                }
            }
            int sum = 0;
            int sumV = 0;
            for(int i = (int)(0+256*0.05f); i< (int)(256 - 256 * 0.05f); i++)
            {
                sum += i;
                sumV += i * gist[i];
            }
            int T =(int)(sumV / (sum * (256 - 256 * 0.1f)));
            Bitmap tempBitmap = new Bitmap(image.Width, image.Height);
            for (int i = 0; i < image.Width; i++)
            {
                for (int j = 0; j < image.Height; j++)
                {
                    if (image.GetPixel(i, j).R < T)
                    {
                        tempBitmap.SetPixel(i, j, Color.FromArgb(0, 0, 0));
                    }
                    else
                    {
                        tempBitmap.SetPixel(i, j, Color.FromArgb(255, 255, 255));
                    }
                }
            }
            image = tempBitmap;
            pictureBox1.Image = tempBitmap;
            pictureBox1.Refresh();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void равномерныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filter filter = new Filter();
            Bitmap resultImage = Uniform.Execute(image);
            pictureBox1.Image = resultImage;
            pictureBox1.Refresh();
        }

        private void гаммаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filter filter = new Filter();
            Bitmap resultImage = Gamma.Execute(image);
            pictureBox1.Image = resultImage;
            pictureBox1.Refresh();
        }

        private void гаусаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filter filter = new Filter();
            Bitmap resultImage = filter.Gaussexecute(image);
            pictureBox1.Image = resultImage;
            pictureBox1.Refresh();
        }

        private void билатеральныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filter filter = new Filter();
            Bitmap resultImage = filter.BilaterialExecute(image);
            pictureBox1.Image = resultImage;
            pictureBox1.Refresh();
        }

        private void sSIMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filter filter = new Filter();
            MessageBox.Show(filter.ExecuteSSIM((Bitmap)pictureBox1.Image, image).ToString());
        }

        private void pSNRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filter filter = new Filter();
            MessageBox.Show(filter.ExecuteSSIM((Bitmap)pictureBox1.Image, image).ToString());
        }

        private void gistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (image == null) return;
            Hist frame = new Hist(Additivemodels.CalculateHistogram());
            frame.Show();
        }
    }
}
