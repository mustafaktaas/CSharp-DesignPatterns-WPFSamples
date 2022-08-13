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
    public class TargetYazıTipi : ITargetYazıTipi
    {
        public void Duzenle(TextBox textbox)
        {
            textbox.FontFamily = new System.Windows.Media.FontFamily("Century Gothic");
            textbox.FontSize = 16;
        }
    }
}
