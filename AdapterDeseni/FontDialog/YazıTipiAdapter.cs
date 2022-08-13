using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;

namespace FontDialog
{
    public class YazıTipiAdapter : ITargetYazıTipi
    {
        AdapteYazıTipi AdapteYazıTipi;

        public YazıTipiAdapter(AdapteYazıTipi adapteYazıTipi)
        {
            this.AdapteYazıTipi = adapteYazıTipi;
        }
        public void Duzenle(TextBox textbox)
        {
            AdapteYazıTipi.Duzenle(textbox);
        }
    }
}
