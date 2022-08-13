using System;
using System.Collections.Generic;
using System.Text;

namespace FontDialog
{
    public interface ISecimFactory
    {
        ISecim SecimYap(Secilen secilen);
    }
}
