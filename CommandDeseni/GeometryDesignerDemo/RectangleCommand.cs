using System;
using System.Collections.Generic;
using System.Text;

namespace GeometryDesignerDemo
{
    public class RectangleCommand : Command
    {
        Sekil sekil;

        public RectangleCommand(Sekil sekil)
        {
            this.sekil = sekil;
        }
        public void execute()
        {
            sekil.rectangle();
        }
    }
}
