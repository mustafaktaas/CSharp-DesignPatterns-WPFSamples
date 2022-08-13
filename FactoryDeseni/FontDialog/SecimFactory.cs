using System;
using System.Collections.Generic;
using System.Text;

namespace FontDialog
{
    public class SecimFactory : ISecimFactory
    {
        public ISecim SecimYap(Secilen secilen)
        {
            ISecim secim = null;
            switch (secilen)
            {
                case Secilen.MyFont:
                    secim = new MyFont();               
                    break;
                case Secilen.Renk:
                    secim = new Renk();
                    break;
                case Secilen.MyFontSize:
                    secim = new MyFontSize();
                    break;
            }
            return secim;
        }
    }
}
