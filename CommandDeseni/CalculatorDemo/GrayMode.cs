using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;
using System.Windows.Media;

namespace CalculatorDemo
{
    public class GrayMode
    {
        public GrayMode() { }

        public void On(TextBox textBox,TextBox textBox1)
        {
            textBox.Background = new SolidColorBrush(Colors.Gray);
            textBox1.Background = new SolidColorBrush(Colors.Gray);
        }

        public void Off(TextBox textBox,TextBox textBox1)
        {
            textBox.Background = new SolidColorBrush(Colors.White);
            textBox1.Background = new SolidColorBrush(Colors.White);
        }

    }
}
