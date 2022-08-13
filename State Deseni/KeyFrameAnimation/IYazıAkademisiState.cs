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


namespace KeyFrameAnimation
{
    public interface IYazıAkademisiState
    {
        public void CenturyGothicYazıTipi(TextBlock textBlock);

        public void FrnaklinGothicYazıTipi(TextBlock textBlock);

        public void ElephantYazıTipi(TextBlock textBlock);

        public void HarlowSolidYazıTipi(TextBlock textBlock);
    }
}
