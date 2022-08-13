using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;

namespace CalculatorDemo
{
    public class RemoteControl
    {
        ICommand slot;

        public RemoteControl() { }

        public void setCommand(ICommand command)
        {
            slot = command;
        }

        public void pressButton(TextBox textBox,TextBox textBox1)
        {
            slot.islem(textBox,textBox1);
        }

    }
}
