using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Blok: ProjektDomu
    {
        public override void PomalujElewacje(Kolor kolor)
        {
            PomalujElewacje(kolor);
        }
        public override void PomalujElewacje()
        {
           
        }




        public override void ZamontujDrzwi(string rodzajDrzwi)
        {
            ZamontujDrzwi("brązowe, dąb");
        }

        public override string ToString()
        {
            return "Blok: " + ToString();
        }
    }
}
