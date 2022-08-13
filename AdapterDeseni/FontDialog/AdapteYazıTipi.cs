using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;
using System.Collections;
using System.IO;
using System.Windows;
using System.Windows.Media.Imaging;
using System.Windows.Media;
using System.Drawing.Design;
using System.Drawing;

namespace FontDialog
{
    public class AdapteYazıTipi : IAdapteeYazıTipi
    {
        public void Duzenle(TextBox textbox)
        {
             textbox.FontFamily = new System.Windows.Media.FontFamily("Italic");
             textbox.FontSize = 22;
        }
    }
}
