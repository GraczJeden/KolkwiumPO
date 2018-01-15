using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Projektant
    {
        ProjektDomu projektDomu;





        public void Buduj(string rodzajOkien, string rodzajDrzwi, Kolor kolor)
        {
            projektDomu.NowyDom();
            projektDomu.WstawOkna(rodzajOkien);
            projektDomu.ZamontujDrzwi(rodzajDrzwi);
            projektDomu.PomalujElewacje(kolor);
        }

        public void Buduj(string rodzajOkien, string rodzajDrzwi)
        {
            projektDomu.NowyDom();
            projektDomu.WstawOkna(rodzajOkien);
            projektDomu.ZamontujDrzwi(rodzajDrzwi);
            projektDomu.PomalujElewacje();
        }


        public void WybierzProjekt(ProjektDomu projekt) 
        {
            this.projektDomu = projekt;
        }

        public override string ToString()
        {
            return projektDomu.ToString();
        }
    }
}
