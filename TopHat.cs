using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.ComponentModel;

namespace CG
{
    class TopHat : MatrixFilter
    {
        public TopHat()
        {
            this.kernel = null;
        }

        public TopHat(float[,] kernel)
        {
            this.kernel = kernel;
        }

        public override Bitmap processImage(Bitmap sourceImage, BackgroundWorker worker)
        {
            Opening opening;
            if (this.kernel == null)
            {
                opening = new Opening();
            }
            else
            {
                opening = new Opening(this.kernel);
            }
            Subtraction subtraction = new Subtraction(sourceImage);
            return subtraction.processImage(opening.processImage(sourceImage, worker), worker);
        }
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            throw new NotImplementedException();
        }
    }
}
