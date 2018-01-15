using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Dom
    {
        string drzwi;
        string okno;
        Kolor kolorElewacji;



        public void PomalujElewacje(Kolor kolor)
        {
            this.kolorElewacji = kolor;
        }

        public override string ToString()
        {
            return "Okna: " + okno + "Drzwi: " + drzwi + "Kolor Elewacji " + kolorElewacji;
        }


        public void WstawOkna(string rodzajOkien)
        {
            this.okno = rodzajOkien;
        }

        public void ZamontujDrzwi(string rodzajDrzwi)
        {
            this.drzwi = rodzajDrzwi;
        }
    }
}
