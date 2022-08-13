using System;
using System.Collections.Generic;
using System.Text;

namespace GeometryDesignerDemo
{
    public class LineCommand : Command
    {
        Sekil sekil;

        public LineCommand(Sekil sekil)
        {
            this.sekil = sekil;
        }
        public void execute()
        {
            sekil.line();
        }
    }
}
