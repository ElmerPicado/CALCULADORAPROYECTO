using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto__calculadora
{
    internal class Factorial
    {
       
        public static float factorial(float n1)
        {
            float valor1 = 1;
            for (int i = 1; i <= n1; i++)
            {

                valor1 *= i;
            }
            return valor1;

        }
    }   
}

