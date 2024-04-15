using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista1ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double diagonal;
            double aresta;
            double area;

            Console.WriteLine("     -- ÁREA DO QUADRADO USANDO SUA DIAGONAL --");

            Console.WriteLine("Digite o valor da diagonal do quadrado em centímetros (cm): ");
            diagonal = double.Parse(Console.ReadLine());

            aresta = (diagonal * diagonal) / 2;
            aresta = Math.Sqrt(aresta);
            area = aresta * aresta;
            Console.WriteLine("A área do quadrado é: {0}cm²", area);
            Console.ReadKey();
        }
    }
}
