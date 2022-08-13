using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;
using System.Windows.Media;

namespace LayoutTransitionsDemo
{
    public class FacadePainter
    {
        private IColor red;
        private IColor blue;
        private IColor white;

        public FacadePainter()
        {
            red = new Red();
            blue = new Blue();
            white = new White();
        }

        public void paintRed(Canvas canvas)
        {
            red.Paint(canvas);
        }
        public void paintBlue(Canvas canvas)
        {
            blue.Paint(canvas);
        }
        public void paintWhite(Canvas canvas)
        {
            white.Paint(canvas);
        }
    }
}
