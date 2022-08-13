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
    public class FranklinGothic : IYazıAkademisiState
    {
        private Student state;

        public FranklinGothic(Student state)
        {
            this.state = state;
        }
        public void CenturyGothicYazıTipi(TextBlock textBlock)
        {
           
        }

        public void ElephantYazıTipi(TextBlock textBlock)
        {
            
        }

        public void FrnaklinGothicYazıTipi(TextBlock textBlock)
        {
            MessageBox.Show("Bu öğrenci 2. seviyededir...");
            textBlock.FontFamily = new System.Windows.Media.FontFamily("Franklin Gothic");
            state.setState(state.getElephant());
        }

        public void HarlowSolidYazıTipi(TextBlock textBlock)
        {
           
        }
    }
}
