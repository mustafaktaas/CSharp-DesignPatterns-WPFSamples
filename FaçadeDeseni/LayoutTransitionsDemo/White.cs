using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;
using System.Windows.Media;


namespace LayoutTransitionsDemo
{
    public class White : IColor
    {
        public void Paint(Canvas canvas)
        {
            canvas.Background = new SolidColorBrush(Colors.White);
        }
    }
}
