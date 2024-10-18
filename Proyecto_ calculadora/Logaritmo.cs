using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto__calculadora
{
    internal class Logaritmo
    {
        public static double principal(double n1)
        {
            double log = 0;
            log = Math.Log10(n1);
            return log;
        }
    }
}
