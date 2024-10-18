using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto__calculadora
{
    internal class Elevado
    {
        public static double diezElevado(double n1)
        {
            double elevado = 0;
            elevado = Math.Pow(10, n1);

            return elevado;
        }
    }
}
