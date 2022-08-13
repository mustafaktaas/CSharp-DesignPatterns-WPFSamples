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
    public class GozlemciYazar2 : IYazıGozleme
    {
        private ListBox listBox;

        public GozlemciYazar2(ListBox listBox)
        {
            this.listBox = listBox;
        }

        public void Update()
        {
            listBox.Items.Add("2. yazarın yazı şeklinin değiştiğinden haberi oldu...");
        }
    }
}
