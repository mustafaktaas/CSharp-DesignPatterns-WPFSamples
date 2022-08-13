using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace AnimationTiming
{
    abstract class Yazı
    {
        public abstract void YazıTipi(TextBlock textBlock);

        public abstract void YazıBoyutu(TextBlock textBlock);

        public void YazıKalınlık(TextBlock textBlock)
        {
            textBlock.FontWeight = FontWeights.SemiBold;
        }
  
        public void Uygula(TextBlock textBlock)
        {
            YazıTipi(textBlock);
            YazıBoyutu(textBlock);
            YazıKalınlık(textBlock);

            if (KullanıcıSor()==true)
            {
                ArkaPlanRenk(textBlock);
            }
        }

        public abstract void ArkaPlanRenk(TextBlock textBlock);

        public abstract bool KullanıcıSor();
        

    }
}
