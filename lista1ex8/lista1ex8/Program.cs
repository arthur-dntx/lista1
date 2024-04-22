using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista1ex8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double celsius;
            double fahrenheit;

            Console.WriteLine("    -- CONVERSÃO DE CELSIUS PARA FAHRENHEIT --");
            Console.Write("Digite a temperatura em graus Celsius: ");
            celsius = Convert.ToDouble(Console.ReadLine());

            fahrenheit = (celsius * 9 / 5) + 32;
            Console.WriteLine("A temperatura em Fahrenheit é: {0} °F", fahrenheit);
            Console.ReadKey();
        }
    }
}
