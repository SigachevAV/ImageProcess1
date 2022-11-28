using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ImageProcess1
{
    internal class Filter
    {
        public Bitmap Gaussexecute(Bitmap source)
        {
            Bitmap resultimage = new Bitmap(source);
            for (int x = 0; x < source.Width; x++)
            {
                for (int y = 0; y < source.Height; y++)
                {
                    resultimage.SetPixel(x, y, GaussFilter(source, x, y));
                }
            }
            return resultimage;
        }
        public Color GaussFilter(Bitmap source, int x, int y)
        {
            double sigma = 2;
            int radius = 1;
            int count = (int)Math.Pow(radius * 2 + 1, 2);
            double sum = 0;
            double Gaussum = 0;
            double Gauss1 = 0;
            double Gauss2 = 0;
            for (int l = -radius; l <= radius; l++)
            {
                for (int k = -radius; k <= radius; k++)
                {
                    int idX = Clamp(x + k, 0, source.Width - 1);
                    int idY = Clamp(y + l, 0, source.Height - 1);
                    Color neighborColor = source.GetPixel(idX, idY);

                    Gauss1 = 1 / (2 * Math.PI * Math.Pow(sigma, 2)) * Math.Exp(-(Math.Pow(l, 2) + Math.Pow(k, 2)) / (2 * Math.Pow(sigma, 2)));
                    Gauss2 = 1 / (Math.Sqrt(2 * Math.PI) * sigma) * Math.Exp(-(Math.Pow((double)neighborColor.R / 255 - (double)source.GetPixel(x, y).R / 255, 2)) / (2 * Math.Pow(sigma, 2)));
                    Gaussum += Gauss1 * Gauss2;
                    sum += Gauss1 * Gauss2 * (double)neighborColor.R / 255;

                }
            }
            return Color.FromArgb(Clamp((int)(sum / Gaussum * 255), 0, 255),
            Clamp((int)(sum / Gaussum * 255), 0, 255),
            Clamp((int)(sum / Gaussum * 255), 0, 255));
        }
        public static int Clamp(int value, int min, int max)
        {
            if (value < min)
            {
                return min;
            }
            if (value > max)
            {
                return max;
            }
            return value;
        }
        public static int clamp(int value, int min, int max)
        {
            return (int)(Math.Min(Math.Max(min, value), max));
        }
        public Bitmap BilaterialExecute(Bitmap source)
        {
            Bitmap resultimage = new Bitmap(source);
            int radius = 1;
            int sigma = 2;
            int size = 2 * radius + 1;
            float[,] kernel = new float[size, size];
            float norm = 0;
            for (int i = -radius; i <= radius; i++)
                for (int j = -radius; j <= radius; j++)
                {
                    kernel[i + radius, j + radius] = (float)(Math.Exp(-(i * i) / 2 * (sigma * sigma)));
                    norm += kernel[i + radius, j + radius];
                }
            for (int i = 0; i < size; i++)
                for (int j = 0; j < size; j++)
                    kernel[i, j] /= norm;
            for (int y = 0; y < source.Height; y++)
                for (int x = 0; x < source.Width; x++)
                {
                    Color Color = NewPixelColorBilaterial(source, kernel, x, y);
                    resultimage.SetPixel(x, y, Color);
                }
            return resultimage;
        }
        public Color NewPixelColorBilaterial(Bitmap source, float[,] kernel, int x, int y)
        {
            int radiusX = kernel.GetLength(0) / 2;
            int radiusY = kernel.GetLength(1) / 2;
            float res = 0;
            for (int l = -radiusY; l <= radiusY; l++)
                for (int k = -radiusX; k <= radiusX; k++)
                {
                    int idX = clamp(x + k, 0, source.Width - 1);
                    int idY = clamp(y + l, 0, source.Height - 1);
                    Color neighborColor = source.GetPixel(idX, idY);
                    res += neighborColor.R * kernel[k + radiusX, l + radiusY];
                }
            return Color.FromArgb(clamp((int)res, 0, 255),
                                 clamp((int)res, 0, 255),
                                 clamp((int)res, 0, 255));
        }
        public float ExecuteSSIM(Bitmap compareImage, Bitmap perfImage)
        {
            Bitmap CompareImage2 = new Bitmap(compareImage);
            Bitmap PerfImage2 = new Bitmap(perfImage);
            float L = (float)(Math.Pow(2, 8) - 1f);
            float k1 = 0.01f, k2 = 0.03f;
            float c1 = (float)Math.Pow(k1 * L, 2);
            float c2 = (float)Math.Pow(k2 * L, 2);


            float meanX = ComputeMean(PerfImage2), meanY = ComputeMean(CompareImage2);
            float disX = ComputeDis(PerfImage2, meanX), disY = ComputeDis(CompareImage2, meanY);
            float covXY = ComputeCov(PerfImage2, meanX, CompareImage2, meanY);


            float ssim, dssim;

            ssim = (2 * meanX * meanY + c1) * (2 * covXY + c2) /
                    (float)((Math.Pow(meanX, 2) + Math.Pow(meanY, 2) + c1) *
                    (Math.Pow(disX, 2) + Math.Pow(disY, 2) + c2));

            dssim = (1 - ssim) / 2;

            return ssim;
        }
        private static float ComputeMean(Bitmap image)
        {
            float sum = 0f;
            for (int i = 0; i < image.Height; i++)
                for (int j = 0; j < image.Width; j++)
                {
                    sum += image.GetPixel(j, i).R;
                    sum += image.GetPixel(j, i).G;
                    sum += image.GetPixel(j, i).B;
                }
            return (sum / (float)(image.Height * image.Width * 3));
        }
        private static float ComputeDis(Bitmap image, float mean)
        {
            float sum = 0f;
            for (int i = 0; i < image.Height; i++)
                for (int j = 0; j < image.Width; j++)
                {
                    sum += (float)Math.Pow(image.GetPixel(j, i).R - mean, 2);
                    sum += (float)Math.Pow(image.GetPixel(j, i).G - mean, 2);
                    sum += (float)Math.Pow(image.GetPixel(j, i).B - mean, 2);
                }
            return (float)Math.Sqrt(sum / ((float)(image.Height * image.Width) - 1f) * 3);
        }
        private static float ComputeCov(Bitmap im1, float m1, Bitmap im2, float m2)
        {
            float sum = 0f;
            for (int i = 0; i < im1.Height; i++)
                for (int j = 0; j < im1.Width; j++)
                {
                    sum += (im1.GetPixel(j, i).R - m1) * (im2.GetPixel(j, i).R - m2);
                    sum += (im1.GetPixel(j, i).G - m1) * (im2.GetPixel(j, i).G - m2);
                    sum += (im1.GetPixel(j, i).B - m1) * (im2.GetPixel(j, i).B - m2);
                }
            return (sum / ((float)(im1.Height * im1.Width) - 1f) * 3);
        }
    }
}
