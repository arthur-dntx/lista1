using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista1ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int b;
            int a;
            int area;

            Console.WriteLine("      -- ÁREA DE UM TRIÂNGULO --");

            Console.WriteLine("Digite a medida da base em centímetros (cm): ");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a altura em centímetros (cm): ");
            a = int.Parse(Console.ReadLine());

            area = (a * b)/2;
            Console.WriteLine("A área do triângulo é: {0}cm²", area);
            Console.ReadKey();
        }
    }
}
