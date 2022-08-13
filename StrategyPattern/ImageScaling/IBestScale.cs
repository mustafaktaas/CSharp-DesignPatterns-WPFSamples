using System;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
namespace ImageScaling
{
   public  interface IBestScale
    {
       int GetBestScale1(double currentPixelsPerDip);
    }
}
