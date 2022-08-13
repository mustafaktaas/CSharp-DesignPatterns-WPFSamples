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
    public abstract class Decorator : IYazımSekil
    {
       
        private IYazımSekil yazımSekil;

        public Decorator(IYazımSekil yazımSekil)
        {

            this.yazımSekil = yazımSekil;

        }       
         public virtual void Kaydırma(ToggleButton toggleButton1, ToggleButton toggleButton2, ToggleButton toggleButton3)
        {

            yazımSekil.Kaydırma(toggleButton1, toggleButton2, toggleButton3);
        
          
        }
    }
}
