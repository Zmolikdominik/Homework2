using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cykly2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadejte delenec");
            int Delenec = int.Parse(Console.ReadLine());
            Console.WriteLine("Zadejte delitel");
            int Delitel = int.Parse(Console.ReadLine());

            int pocitadlo = 0;

            while(Delenec > Delitel)
            {
                Delenec = Delenec - Delitel;
                pocitadlo++;
            }

            Console.WriteLine(pocitadlo + " " + Delenec);

            Console.ReadKey();
        }
    }
}
