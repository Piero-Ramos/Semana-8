using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ga, fi;

            Console.Write("Ingrese un número: "); ga = int.Parse(Console.ReadLine());

            fi = Factorial.numero(ga);

            Console.WriteLine("El factorial de "+ ga + "! es: " + fi);
            Console.Write("Pulse una tecla");
            Console.ReadKey();
        }
    }
}
