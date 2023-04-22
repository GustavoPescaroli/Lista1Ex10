using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double real;
            double dolar = 5.05;
            double x;

            Console.WriteLine("Valor em reais");
            x = double.Parse(Console.ReadLine());

            real = dolar * x;
            Console.WriteLine("Reais {0}", real);
            
        }
    }
}
