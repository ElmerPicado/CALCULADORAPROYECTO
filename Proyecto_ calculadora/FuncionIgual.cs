using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Proyecto_calculadora;

namespace Proyecto__calculadora
{
    internal class FuncionIgual()
    {
        public static double Operacion(double num1, double num2, bool suma, bool resta, bool multiplicacion, bool division, bool potencia)
        {
            if(suma == true)
            {
                double resultado = SUMA.sumar(num1, num2);
                return resultado;
            } 
            else if(resta == true)
            {
                double resultado = Resta.restars(num1, num2);
                return resultado;
            } 
            else if(multiplicacion == true)
            {
                double resultado = Multiplicacion.Multiplicar(num1, num2);
                return resultado;
            } 
            else if(division == true)
            {
                double resultado = Division.Dividir(num1, num2);
                return resultado;
            } 
            else if(potencia == true)
            {
                double resultado = Potencia.PotenciaNumero(num1, num2);
                return resultado;
            }
            else
            {
                return 0;
            }
            ;
        }
    }
}
