using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CG
{
    class MedianFilter : MatrixFilter
    {
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            int radiusX = 3 / 2;
            int radiusY = 3 / 2;
            List<float> listR = new List<float>();
            List<float> listG = new List<float>();
            List<float> listB = new List<float>();
            for (int l = -radiusX; l <= radiusX; ++l)
                for (int k = -radiusY; k <= radiusY; ++k)
                {
                    int idx = Clamp(x + k, 0, sourceImage.Width - 1);
                    int idy = Clamp(y + l, 0, sourceImage.Height - 1);
                    Color neighborColor = sourceImage.GetPixel(idx, idy);
                    listR.Add(neighborColor.R);
                    listG.Add(neighborColor.G);
                    listB.Add(neighborColor.B);
                }
            listR.Sort();
            listG.Sort();
            listB.Sort();
            return Color.FromArgb((int)listR[listR.Count() / 2], (int)listG[listG.Count() / 2], (int)listB[listB.Count() / 2]);
        }
    }
}
