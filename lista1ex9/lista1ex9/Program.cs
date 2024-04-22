using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista1ex9
{
    internal class Program
    {
        static void Main(string[] args)
        {
           double diametro;
           double raio;
           double area;

            Console.WriteLine("    -- DIAMETRO DO CIRCULO --");

           Console.Write("Digite o diâmetro do círculo: ");
            diametro = Convert.ToDouble(Console.ReadLine());

            raio = diametro / 2;
            area = Math.PI * (raio * raio);
            Console.WriteLine("A área do círculo é: {0} unidades de área", area);
            Console.ReadKey();
        }
    }
}
