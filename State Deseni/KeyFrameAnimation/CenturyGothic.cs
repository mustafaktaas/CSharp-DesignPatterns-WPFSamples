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
    public class CenturyGothic : IYazıAkademisiState
    {
        private Student state;

        public CenturyGothic(Student state)
        {
            this.state = state;
        }
        public void CenturyGothicYazıTipi(TextBlock textBlock)
        {
            MessageBox.Show("Bu öğrenci ilk seviyededir...");
            textBlock.FontFamily = new System.Windows.Media.FontFamily("Century Gothic");
            state.setState(state.getFranklinGothic());
        }

        public void ElephantYazıTipi(TextBlock textBlock)
        {
           
        }

        public void FrnaklinGothicYazıTipi(TextBlock textBlock)
        {
           
        }

        public void HarlowSolidYazıTipi(TextBlock textBlock)
        {
           
        }
    }
}
