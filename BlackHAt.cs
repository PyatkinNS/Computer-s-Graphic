using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.ComponentModel;

namespace CG
{
    class BlackHat : MatrixFilter
    {
        public BlackHat()
        {
            this.kernel = null;
        }

        public BlackHat(float[,] kernel)
        {
            this.kernel = kernel;
        }

        public override Bitmap processImage(Bitmap sourceImage, BackgroundWorker worker)
        {
            Closing closing;
            if (this.kernel == null)
            {
                closing = new Closing();
            }
            else
            {
                closing = new Closing(this.kernel);
            }
            Subtraction subtraction = new Subtraction(closing.processImage(sourceImage, worker));
            return subtraction.processImage(sourceImage, worker);
        }
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            throw new NotImplementedException();
        }
    }
}
