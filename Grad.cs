﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.ComponentModel;

namespace CG
{
    class Grad : Filters
    {
        public override Bitmap processImage(Bitmap sourceImage, BackgroundWorker worker)
        {
            Dilation dilation = new Dilation();
            Erosion erosion = new Erosion();
            Subtraction subtraction = new Subtraction(dilation.processImage(sourceImage, worker));
            return subtraction.processImage(erosion.processImage(sourceImage, worker), worker);
        }
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            throw new NotImplementedException();
        }
    }
}
