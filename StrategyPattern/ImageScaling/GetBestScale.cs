using System;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;


namespace ImageScaling
{
    public class GetBestScale : IBestScale
    {
        public  int GetBestScale1(double currentPixelsPerDip)
        {
            int currentScale = (int)(currentPixelsPerDip * 100);
            int bestScale;

            if (currentScale > 200)
            {
                bestScale = 400;
            }
            else if (currentScale > 100)
            {
                bestScale = 200;
            }
            else
            {
                bestScale = 100;
            }

            return bestScale;
        }
    }
}
