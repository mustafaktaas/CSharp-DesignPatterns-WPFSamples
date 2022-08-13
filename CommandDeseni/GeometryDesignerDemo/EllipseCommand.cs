using System;
using System.Collections.Generic;
using System.Text;

namespace GeometryDesignerDemo
{
    public class EllipseCommand : Command
    {
        Sekil sekil;

        public EllipseCommand(Sekil sekil)
        {
            this.sekil = sekil;
        }
        public void execute()
        {
            sekil.ellipse();
        }
    }
}
