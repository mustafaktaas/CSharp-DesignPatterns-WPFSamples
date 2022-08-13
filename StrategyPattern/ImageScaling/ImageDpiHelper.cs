﻿using System;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace ImageScaling
{
    public static class ImageDpiHelper
    {
        /// <summary>
        /// Given an image, get its current DPI and choose the best source image to scale to that DPI.
        /// </summary>
        /// <param name="image">image element</param>
        /// <returns>image URL for the most appropriate scale, given DPI</returns>
        /// 

         static Strategy strategy = new Strategy(new GetBestScale());
        public static string GetDesiredImageUrlForDpi(Image image)
        {            
            DpiScale imageScaleInfo = VisualTreeHelper.GetDpi(image);
            int bestScale = ImageDpiHelper.strategy.GetBestScale1(imageScaleInfo.PixelsPerDip);

            var sourceUrl = image.Source.ToString();
            string imagePattern = Regex.Replace(sourceUrl, ".scale-[0-9]{3}.", ".scale-{0}.");

            string newImagePath = null;
            if (imagePattern != null)
            {
                newImagePath = string.Format(imagePattern, bestScale);
            }

            return newImagePath;
        }


        /*
        public static int GetBestScale(double currentPixelsPerDip)
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
        */
        /// <summary>
        /// Updates the image's Source to the newImagePath
        /// </summary>
        /// <param name="image">image element</param>
        /// <param name="newImagePath">URI of the desired image to use</param>
        public static void UpdateImageSource(Image image, string newImagePath)
        {
            Uri uri = new Uri(newImagePath, UriKind.RelativeOrAbsolute);
            BitmapImage bitmapImage = new BitmapImage(uri);
            image.Source = bitmapImage;
        }
    }
}
