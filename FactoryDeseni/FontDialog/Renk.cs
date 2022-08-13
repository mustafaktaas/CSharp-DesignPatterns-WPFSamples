using System;
using System.Collections.Generic;
using System.Text;
using System;
using System.Collections;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using System.Windows.Media;
namespace FontDialog
{
    public class Renk : ISecim
    {
        public void Degistir(TextBox textBox)
        {
            textBox.Background = Brushes.Gray;
        }
    }
}
