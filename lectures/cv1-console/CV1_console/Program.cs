using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV1_console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadejte jméno");
            string jmeno = Console.ReadLine();
            Console.WriteLine("Zadejte ulici");
            string ulice = Console.ReadLine();
            Console.WriteLine("Zadejte PSČ");
            string psc = Console.ReadLine();
            Console.WriteLine("Zadejte město");
            string mesto = Console.ReadLine();

            Console.WriteLine("Vaše adresa:");

            Console.WriteLine(jmeno);
            Console.WriteLine(ulice);
            Console.WriteLine(psc + " " + mesto);
           
            Console.ReadKey();
        }
    }
}
