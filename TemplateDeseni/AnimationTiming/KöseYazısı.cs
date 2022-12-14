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

namespace AnimationTiming
{
     class KöseYazısı : Yazı
    {
        public override void ArkaPlanRenk(TextBlock textBlock)
        {
            textBlock.Background = Brushes.Red;
        }

        public override bool KullanıcıSor()
        {
            if (MessageBox.Show("Arka Plan Renk Kırmızı Olsun Mu?", "Soru", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override void YazıBoyutu(TextBlock textBlock)
        {
            textBlock.FontSize = 14;
        }
        public override void YazıTipi(TextBlock textBlock)
        {
            textBlock.FontFamily = new System.Windows.Media.FontFamily("Arial Narrow");
        }
    }
}
