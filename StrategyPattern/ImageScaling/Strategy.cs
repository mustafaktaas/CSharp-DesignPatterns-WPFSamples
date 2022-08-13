using System;
using System.Collections.Generic;
using System.Text;

namespace ImageScaling
{
    public class Strategy 
    {
        private IBestScale bestScale;

        public Strategy(IBestScale bestScale)
        {
            this.bestScale = bestScale;
        }
        
       public int GetBestScale1(double currentPixelsPerDip)
        {
           return bestScale.GetBestScale1(currentPixelsPerDip);
        }
    }
}
