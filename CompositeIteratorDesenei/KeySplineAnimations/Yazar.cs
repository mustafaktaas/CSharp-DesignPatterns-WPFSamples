using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;


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

        public void PrintUstDuzeyMenu()
        {
            var iterator = _hepsiYazı.CreateIterator();

            MessageBox.Show("Ust Duzey Yazılar:");
            while (iterator.MoveNext())
            {
                YazıOzellik yazıOzellik = iterator.Current;
                try
                {
                    if (yazıOzellik.IsUstDuzey)
                    {
                        yazıOzellik.Print();
                    }
                }
                catch (NotImplementedException) { }
            }
        }
    }
}
