using System;
using System.Collections.Generic;
using System.Text;

namespace KeySplineAnimations
{
    public class YazıOzellik
    {
        public string YazıTip { get; set; }
        public int Boyut { get; set; }

        public YazıOzellik(string yazıTip, int boyut)
        {
            YazıTip = yazıTip;
            Boyut = boyut;
        }
    }
}
