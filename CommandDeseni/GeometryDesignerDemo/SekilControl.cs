using System;
using System.Collections.Generic;
using System.Text;

namespace GeometryDesignerDemo
{
    public class SekilControl
    {
        Command slot;

        public SekilControl() { }

        public void setCommand(Command command)
        {
            slot = command;
        }

        public void butonPressed()
        {
            slot.execute();
        }
    }
}
