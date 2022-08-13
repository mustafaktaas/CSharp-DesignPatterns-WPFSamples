using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;

namespace CalculatorDemo
{
    public class GrayModeOffCommand : ICommand
    {
        GrayMode grayMode;

        public GrayModeOffCommand(GrayMode grayMode)
        {
            this.grayMode = grayMode;
        }
        public void islem(TextBox textBox,TextBox textBox1)
        {
            grayMode.Off(textBox,textBox1);
        }
    }
}
