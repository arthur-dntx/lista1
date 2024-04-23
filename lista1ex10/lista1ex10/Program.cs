using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista1ex10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double cotacaoDolar;
            double quantidadeDolares;
            double valorEmReais;

            Console.WriteLine("    -- COTAÇÃO DE DÓLARES PARA REAIS --");

            Console.Write("Digite a cotação do dólar: ");
            cotacaoDolar = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Digite a quantidade de dólares: ");
            quantidadeDolares = Convert.ToDouble(Console.ReadLine());
            valorEmReais = quantidadeDolares * cotacaoDolar;
            
            Console.WriteLine("O valor em Reais é: R$ {0", valorEmReais);
            
            Console.ReadKey();
        }
    }
}
