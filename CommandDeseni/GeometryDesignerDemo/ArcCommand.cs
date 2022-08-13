using System;
using System.Collections.Generic;
using System.Text;

namespace GeometryDesignerDemo
{
    public class ArcCommand : Command
    {
        Sekil sekil;

        public ArcCommand(Sekil sekil)
        {
            this.sekil = sekil;
        }
        public void execute()
        {
            sekil.arc();
        }
    }
}
