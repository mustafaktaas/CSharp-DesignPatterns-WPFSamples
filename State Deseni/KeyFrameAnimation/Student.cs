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
    public class Student
    {
        private IYazıAkademisiState centuryGothic;
        private IYazıAkademisiState franklinGothic;
        private IYazıAkademisiState elephantGothic;
        private IYazıAkademisiState harlowSolid;
        private IYazıAkademisiState yazıAkademisiState;

        public Student()
        {
            centuryGothic = new CenturyGothic(this);
            franklinGothic = new FranklinGothic(this);
            elephantGothic = new Elephant(this);
            harlowSolid = new HarlowSolid(this);
            yazıAkademisiState = centuryGothic;
        }

        public void centuryGothic1(TextBlock textBlock)
        {
            yazıAkademisiState.CenturyGothicYazıTipi(textBlock);
        }

        public void franklinGothic1(TextBlock textBlock)
        {
            yazıAkademisiState.FrnaklinGothicYazıTipi(textBlock);
        }

        public void elephantGothic1(TextBlock textBlock)
        {
            yazıAkademisiState.ElephantYazıTipi(textBlock);
        }

        public void harlowSolid1(TextBlock textBlock)
        {
            yazıAkademisiState.HarlowSolidYazıTipi(textBlock);
        }

        public void setState(IYazıAkademisiState yazıAkademisiState)
        {
            this.yazıAkademisiState = yazıAkademisiState;
        }

        public IYazıAkademisiState getIYazıAkademisiState()
        {
            return yazıAkademisiState;
        }

        public IYazıAkademisiState getCenturyGothic()
        {
            return centuryGothic;
        }

        public IYazıAkademisiState getFranklinGothic()
        {
            return franklinGothic;
        }

        public IYazıAkademisiState getElephant()
        {
            return elephantGothic;
        }

        public IYazıAkademisiState getHarlowSolid()
        {
            return harlowSolid;
        }
    }
}
