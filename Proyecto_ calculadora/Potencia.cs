using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_calculadora{
  internal class Potencia{
    public static double PotenciaNumero(double n1, double   n2)
    {
      double resultado = Math.Pow(n1, n2);
      return resultado;
    } 

    public static double PotenciaAlCuadrado(double num1){
      double resultado = Math.Pow(num1, 2);
      return resultado;
    }
  }
}
