using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista1ex6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double v1;
            double v2;
            double media;

            Console.WriteLine("    -- MÉDIA GEOMÉTRICA DE DOIS VALORES --");

            Console.WriteLine("Digite o primeiro valor: ");
            v1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor: ");
            v2 = double.Parse(Console.ReadLine());

            media = Math.Sqrt(v1 * v2);

            Console.WriteLine("A média geométrica é {0}.", media);
            Console.ReadKey();
        }
    }
}
