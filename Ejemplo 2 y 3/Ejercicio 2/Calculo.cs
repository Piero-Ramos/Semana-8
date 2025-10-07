using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    internal class Calculo
    {
        public static int exponente (int a, int b)
        {
            int c = 1;
            if (b == 0)
            {
                return 1;
            }
            else
            {
                for (int i = 1; i <= b; i++)
                {
                    c = c * a;
                }
                return c;
            }
        }
    }
}
