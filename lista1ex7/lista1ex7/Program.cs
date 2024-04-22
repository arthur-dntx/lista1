using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista1ex7
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            double milhasMaritimas;
            double quilometros;

            Console.WriteLine("    -- CONVERSÃO DE MILHAS MARÍTIMAS PARA QUILÔMETROS --");

            Console.Write("Digite o valor em milhas marítimas: ");
            milhasMaritimas = Convert.ToDouble(Console.ReadLine());

            quilometros = milhasMaritimas * 1852 / 1000;
            Console.WriteLine("{0} milhas marítimas equivalem a {1} quilômetros",milhasMaritimas, quilometros);
            Console.ReadKey();
        }
    }
}
