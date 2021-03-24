using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.ComponentModel;

namespace CG
{
    class IdealMirror : Filters
    {
        float maxR = -1;
        float maxG = -1;
        float maxB = -1;
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            Color sourceColor = sourceImage.GetPixel(x, y);
            if (maxR == -1 && maxG == -1 && maxB == -1)
            {
                for (int i = 0; i < sourceImage.Width; i++)
                    for (int j = 0; j < sourceImage.Height; j++)
                    {
                        if (sourceColor.R > maxR) maxR = sourceColor.R;
                        if (sourceColor.G > maxG) maxG = sourceColor.G;
                        if (sourceColor.B > maxB) maxB = sourceColor.B;
                    }
            }
            Color resultColor = Color.FromArgb(Clamp((int)(sourceColor.R * 255 / maxR), 0, 255),
                                               Clamp((int)(sourceColor.G * 255 / maxG), 0, 255),
                                               Clamp((int)(sourceColor.B * 255 / maxB), 0, 255));
            return resultColor;
        }
    }
}
