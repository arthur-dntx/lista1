using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista1ex5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int v1;
            int v2;
            int v3;
            int v4;
            int media;

            Console.WriteLine("    -- MÉDIA ARITMÉTICA --");

            Console.WriteLine("Digite 4 números teclando 'enter' após a digitação de cada um deles: ");

            v1 = int.Parse(Console.ReadLine());
            v2 = int.Parse(Console.ReadLine());
            v3 = int.Parse(Console.ReadLine());
            v4 = int.Parse(Console.ReadLine());

            media = (v1 + v2 + v3 + v4)/4;

            Console.WriteLine("A média é {0}.", media);
            Console.ReadKey();
        }
    }
}
