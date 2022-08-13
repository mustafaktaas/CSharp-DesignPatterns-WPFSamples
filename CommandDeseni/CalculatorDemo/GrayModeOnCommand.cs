using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;

namespace CalculatorDemo
{
    public class GrayModeOnCommand : ICommand
    {
        GrayMode grayMode;

        public GrayModeOnCommand(GrayMode grayMode)
        {
            this.grayMode = grayMode;
        }
        public void islem(TextBox textBox,TextBox textBox1)
        {
            grayMode.On(textBox,textBox1);
        }
    }
}
