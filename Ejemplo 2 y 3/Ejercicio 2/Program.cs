using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nu, me, ra;

            Console.Write("Ingrese un número: "); nu = int.Parse(Console.ReadLine());
            Console.Write("Ingrese un exponente: "); me = int.Parse(Console.ReadLine());

            ra = Calculo.exponente(nu,me);

            Console.WriteLine("La potencia es: "+ ra);
            Console.Write("Pulse una tecla");
            Console.ReadKey();

            
        }
    }
}
