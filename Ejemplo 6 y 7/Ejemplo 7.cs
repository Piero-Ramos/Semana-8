using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        // Método con paso por valor
        static void incremento1(int n1)
        {
            n1 = n1 + 10;
        }

        // Método con paso por referencia
        static void incremento2(ref int n1)
        {
            n1 = n1 + 10;
        }

        static void Main(string[] args)
        {
            int a = 10;
            int b = 10;

            incremento1(a);       // paso por valor
            incremento2(ref b);   // paso por referencia

            Console.WriteLine("a = " + a); // no cambia
            Console.WriteLine("b = " + b); // cambia

            Console.ReadKey();
        }
    }
}
