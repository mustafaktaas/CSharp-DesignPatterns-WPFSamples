﻿using System;
using System.Collections.Generic;
using System.Text;
using System;
using System.Collections;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using System.Windows.Media;
using System.Drawing.Design;
using System.Drawing;
using FontFamily = System.Drawing.FontFamily;

namespace FontDialog
{
    public class MyFont : ISecim
    {
        public void Degistir(TextBox textBox)
        {
            textBox.FontFamily = new System.Windows.Media.FontFamily("Century Gothic");
        } 
    }
}
