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
    public class Elephant : IYazıAkademisiState
    {
        private Student state;

        public Elephant(Student state)
        {
            this.state = state;
        }
        public void CenturyGothicYazıTipi(TextBlock textBlock)
        {
           
        }

        public void ElephantYazıTipi(TextBlock textBlock)
        {
            MessageBox.Show("Bu öğrenci 3. seviyededir...");
            textBlock.FontFamily = new System.Windows.Media.FontFamily("Elephant");
            state.setState(state.getHarlowSolid());
        }

        public void FrnaklinGothicYazıTipi(TextBlock textBlock)
        {
            
        }

        public void HarlowSolidYazıTipi(TextBlock textBlock)
        {
            
        }
    }
}
