using System;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;


namespace ImageScaling
{
    public class GetBestScale2 : IBestScale
    {
        public int GetBestScale1(double currentPixelsPerDip)
        {
            int currentScale = (int)(currentPixelsPerDip * 100);
            int bestScale;

            if (currentScale > 200)
            {
                bestScale = 300;
            }
            else if (currentScale > 100)
            {
                bestScale = 160;
            }
            else
            {
                bestScale = 80;
            }

            return bestScale;
        }
    }
}
