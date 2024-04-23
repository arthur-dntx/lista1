using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista1ex11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x;
            double y;
            double result;

            Console.WriteLine("    -- POTÊNCIA DE 'X' ELEVADO A 'Y'");

            Console.Write("Digite o valor de X: ");
            x = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o valor de Y: ");
            y = Convert.ToDouble(Console.ReadLine());

            result = Math.Pow(x, y);

            Console.WriteLine("O resultado de X elevado a Y é: {0}", result);
            Console.ReadKey();
        }
    }
}
