using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {

            Projektant projektant1 = new Projektant();

            Console.WriteLine("Wcisnij cokolwiek, zeby wystartowac");
            ConsoleKeyInfo input = Console.ReadKey();
            while(input.Key != ConsoleKey.X)
            {
                Console.WriteLine("Sterowanie:");
                Console.WriteLine("B - Buduj blok");
                Console.WriteLine("J - Buduj dom jednorodzinny");
                Console.WriteLine("X - Wyjdz z aplikacji");
                input = Console.ReadKey();
                Console.WriteLine();
                switch(input.Key)
                {
                    case ConsoleKey.B:
                        projektant1.WybierzProjekt(new DomJednorodzinny());
                        Console.WriteLine("Prosze podac rodzajOkien");
                        string rodzajOkien = Console.ReadLine();
                        Console.WriteLine("Prosze podac rodzaj Drzwi");
                        string rodzajDrzwi = Console.ReadLine();
                        projektant1.Buduj(rodzajOkien, rodzajDrzwi);
                        Console.WriteLine("Wybudowano" + projektant1.ToString());
                        break;
                    
                    case ConsoleKey.J:
                    
                            Console.WriteLine();
                            Console.WriteLine("Obejrzyj");
                            break;
                    

                    case ConsoleKey.X:
                    
                            Console.WriteLine();
                            Console.WriteLine("Wylaczanie aplikacji");
                            break;
                    
                    default:
                        Console.WriteLine("Zle polecenie");
                        break;
                }

            }
            








            Console.ReadKey();
        }
    }
}
