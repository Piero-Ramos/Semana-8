using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static int buscarMayor(int a, int b, int c)
        {
            int mayor;
            if (a > b && a > c)
            {
                mayor = a;
            }
            else
            {
                if (b > c)
                {
                    mayor = b;
                }
                else
                {
                    mayor = c;
                }
            }
            return mayor;
        }

        static int buscarMenor(int a, int b, int c)
        {
            int menor;
            if (a <= b && a <= c)
            {
                menor = a;
            }
            else
            {
                if (b < c)
                {
                    menor = b;
                }
                else
                {
                    menor = c;
                }
            }
            return menor;
        }

        static int buscarIntermedio(int a, int b, int c, int mayor, int menor)
        {
            int inter;
            inter = (a + b + c) - (mayor + menor);
            return inter;
        }

        static void Main(string[] args)
        {
            int a, b, c, mayor, menor, inter;
            Console.Write("Ingresar numero 1: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Ingresar numero 2: ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Ingresar numero 3: ");
            c = int.Parse(Console.ReadLine());

            mayor = buscarMayor(a, b, c);
            menor = buscarMenor(a, b, c);
            inter = buscarIntermedio(a, b, c, mayor, menor);

            Console.WriteLine("El mayor es = {0}", mayor);
            Console.WriteLine("El menor es = {0}", menor);
            Console.WriteLine("El intermedio es = {0}", inter);
            Console.ReadKey();
        }

    }
}
