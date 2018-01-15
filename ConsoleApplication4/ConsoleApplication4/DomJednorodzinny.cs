using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class DomJednorodzinny: ProjektDomu
    {
        public override void PomalujElewacje(Kolor kolor)
        {
            PomalujElewacje(Kolor.Niebieski);
        }



        public override void PomalujElewacje()
        {
            PomalujElewacje(Kolor.Niebieski);
        }
        public override string ToString()
        {
            return "Dom jednorodzinny: " + ToString();
        }

    }
}
