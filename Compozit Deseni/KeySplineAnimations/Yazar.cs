using System;
using System.Collections.Generic;
using System.Text;

namespace KeySplineAnimations
{
    public class Yazar
    {
       
        private readonly YazıOzellik _hepsiYazı;

        public Yazar(YazıOzellik hepsiYazı)
        {
            _hepsiYazı = hepsiYazı;
        }

        public void PrintMenu()
        {
            _hepsiYazı.Print();
        }

    }
}
