using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace KeySplineAnimations
{
    public class YazıKullanım : YazıOzellik
    {
      
        public YazıKullanım(string name, bool ustDuzey)
        {
            Name = name;
            IsUstDuzey = ustDuzey;
        }

        public override string Name { get; }
        public override bool IsUstDuzey { get; }

        public override void Print()
        {
            MessageBox.Show(Name);

            if (IsUstDuzey)
            {
            }
        }
    }
}
