using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.ComponentModel;

namespace CG
{
    class GrayWorld : Filters
    {
        float avgR = 0;
        float avgG = 0;
        float avgB = 0;
        float avg = -1;
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            Color sourceColor = sourceImage.GetPixel(x, y);
            if (avg == -1)
            {
                int pixcount = sourceImage.Width * sourceImage.Height;
                for (int i = 0; i < sourceImage.Width; i++)
                    for (int j = 0; j < sourceImage.Height; j++)
                    {
                        avgR += sourceColor.R;
                        avgG += sourceColor.G;
                        avgB += sourceColor.B;
                    }
                avgR /= pixcount;
                avgG /= pixcount;
                avgB /= pixcount;
                avg = (avgR + avgG + avgB) / 3;
                avgR = avg / avgR;
                avgG = avg / avgG;
                avgB = avg / avgB;
            }

            Color resultColor = Color.FromArgb(Clamp((int)(sourceColor.R * avgR), 0, 255),
                                               Clamp((int)(sourceColor.G * avgG), 0, 255),
                                               Clamp((int)(sourceColor.B * avgB), 0, 255));
            return resultColor;
        }

    }
}

