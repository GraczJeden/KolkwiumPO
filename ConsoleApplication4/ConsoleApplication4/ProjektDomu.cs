using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    abstract class ProjektDomu
    {
        internal Dom dom;





        public void NowyDom()
        {
            this.dom = new Dom();
        }

        public virtual  void WstawOkna(string rodzajOkien)
        {
            dom.WstawOkna(rodzajOkien);
        }


        public virtual void ZamontujDrzwi(string rodzajDrzwi)
        {
            dom.WstawOkna(rodzajDrzwi);
        }

        public abstract void PomalujElewacje(Kolor kolor);

        public abstract void PomalujElewacje();

        public override string ToString()
        {
            return dom.ToString();
        }


    }
}
