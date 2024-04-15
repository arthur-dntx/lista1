using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista1ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int aresta;
            int area;

            Console.WriteLine("     -- ÁREA DO QUADRADO --");

            Console.WriteLine("Digite o valor de uma aresta em centímetros (cm): ");
            aresta = int.Parse(Console.ReadLine());

            area = aresta * aresta;
            Console.WriteLine("A área do quadrado é: {0}cm²", area);
            Console.ReadKey();
        }
    }
}
