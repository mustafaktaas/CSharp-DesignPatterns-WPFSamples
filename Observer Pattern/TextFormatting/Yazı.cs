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
    public class Yazı : IYazıGozlemci
    {
        private List<IYazıGozleme> yazarObservers = new List<IYazıGozleme>();

        //private ListBox listBox;
        public void YazarEkle(IYazıGozleme yazıGozleme)
        {
            yazarObservers.Add(yazıGozleme);
        }

        public void YazarlaraHaberVer()
        {
            yazarObservers.ForEach(yazarObservers => { yazarObservers.Update(); });
        }
    }
}
