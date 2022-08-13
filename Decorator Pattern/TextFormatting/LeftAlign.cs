using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TextFormatting
{
    public class LeftAlign : Decorator
    {
     public LeftAlign(IYazımSekil yazımSekil) : base(yazımSekil) { }

        public override void Kaydırma(ToggleButton toggleButton1, ToggleButton toggleButton2, ToggleButton toggleButton3)
        {
            base.Kaydırma(toggleButton1, toggleButton2, toggleButton3);
            toggleButton1.IsChecked = false;
            toggleButton2.IsChecked = false;
            toggleButton3.IsChecked = false;
        }

    }
}
