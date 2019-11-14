using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace ImageEdgeDetection
{
    class ImageFilter
    {
        public static Bitmap MiamiFilter(Bitmap bmp)
        {
            int alpha = 1;
            int red = 1;
            int blue = 10;
            int green = 1;
            Bitmap temp = new Bitmap(bmp.Width, bmp.Height);


            for (int i = 0; i < bmp.Width; i++)
            {
                for (int x = 0; x < bmp.Height; x++)
                {
                    Color c = bmp.GetPixel(i, x);
                    Color cLayer = Color.FromArgb(c.A / alpha, c.R / red, c.G / green, c.B / blue);
                    temp.SetPixel(i, x, cLayer);
                }

            }
            return temp;
        }
        public static Bitmap MegaFilterGreen(Bitmap bmp)
        {
            int max = 230;
            int min = 110;
            Color co = Color.Green;
            Bitmap temp = new Bitmap(bmp.Width, bmp.Height);

            for (int i = 0; i < bmp.Width; i++)
            {
                for (int x = 0; x < bmp.Height; x++)
                {

                    Color c = bmp.GetPixel(i, x);
                    if (c.G > min && c.G < max)
                    {
                        Color cLayer = Color.White;
                        temp.SetPixel(i, x, cLayer);
                    }
                    else
                    {
                        temp.SetPixel(i, x, co);
                    }

                }

            }
            return temp;
        }
    }
}
