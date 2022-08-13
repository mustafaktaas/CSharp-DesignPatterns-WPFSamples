using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;

namespace CalculatorDemo
{
    public interface ICommand
    {
        public void islem(TextBox textBox,TextBox textBox1);
    }
}
