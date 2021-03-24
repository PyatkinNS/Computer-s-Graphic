using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CG
{
    class LinearExtension : Filters
    {
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            throw new NotImplementedException();
        }
        public override Bitmap processImage(Bitmap sourceImage, BackgroundWorker worker)
        {
            Color resultColor;
            Bitmap resultImage = new Bitmap(sourceImage.Width, sourceImage.Height);
            double[] max = new double[3];
            double[] min = new double[3];
            for (int i = 0; i < 3; i++) max[i] = 0d;
            for (int i = 0; i < 3; i++) min[i] = 0d;
            for (int y = 0; y < sourceImage.Height; y++)
            {
                for (int x = 0; x < sourceImage.Width; x++)
                {
                    if (max[0] < sourceImage.GetPixel(x, y).R)
                        max[0] = sourceImage.GetPixel(x, y).R;
                    if (max[1] < sourceImage.GetPixel(x, y).G)
                        max[1] = sourceImage.GetPixel(x, y).G;
                    if (max[2] < sourceImage.GetPixel(x, y).B)
                        max[2] = sourceImage.GetPixel(x, y).B;
                    if (min[0] > sourceImage.GetPixel(x, y).R)
                        min[0] = sourceImage.GetPixel(x, y).R;
                    if (min[1] > sourceImage.GetPixel(x, y).G)
                        min[1] = sourceImage.GetPixel(x, y).G;
                    if (min[2] > sourceImage.GetPixel(x, y).B)
                        min[2] = sourceImage.GetPixel(x, y).B;
                }
            }
            for (int x = 0; x < sourceImage.Width; x++)
            {
                worker.ReportProgress((int)((float)x / resultImage.Width * 100));
                if (worker.CancellationPending) return null;
                for (int y = 0; y < sourceImage.Height; y++)
                {
                    resultColor = Color.FromArgb(Clamp((sourceImage.GetPixel(x, y).R - (int)min[0]) * (int)(255 / (max[0] - min[0])), 0, 255),
                                                 Clamp((sourceImage.GetPixel(x, y).G - (int)min[1]) * (int)(255 / (max[1] - min[1])), 0, 255),
                                                 Clamp((sourceImage.GetPixel(x, y).B - (int)min[2]) * (int)(255 / (max[2] - min[2])), 0, 255));
                    resultImage.SetPixel(x, y, resultColor);
                }
            }

            return resultImage;
        }
    }
}
