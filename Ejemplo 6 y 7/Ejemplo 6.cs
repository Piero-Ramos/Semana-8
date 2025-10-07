using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        // Variables globales
        static int num1;
        static int num2;
        static int resultado;

        // Método para ingresar los números
        static void Ingresar()
        {
            Console.Write("Ingrese el primer número natural: ");
            num1 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el segundo número natural: ");
            num2 = int.Parse(Console.ReadLine());
        }

        // Método para sumar los números
        static void Sumar()
        {
            resultado = num1 + num2;
        }

        // Método para imprimir el resultado
        static void Imprimir()
        {
            Console.WriteLine("La suma de {0} + {1} es: {2}", num1, num2, resultado);
        }

        static void Main(string[] args)
        {
            Ingresar();
            Sumar();
            Imprimir();

            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
