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
    internal class FuncionBotones
    {
        
        public static void funcionBotones_(ref bool coma, ref bool suma, ref  string valor2, ref string n,
            ref string decima, ref bool resta, Label resultado,ref bool potenciaxy)
        {
            if (coma == true && suma == true && resta == false) {
                valor2 = resultado.Text + n;
                decima = valor2;
                coma = false;
              
            }
            else if (coma == true && suma == false && resta == true)
            {
                valor2 = resultado.Text + n;
                decima = valor2;
                coma = false;
            }


            else if (suma == true && coma == false && resta == false)
            {

                Form1.Reset();
                resultado.Text = string.Empty;
                valor2 = resultado.Text + n;
                decima = valor2;
                coma = true;



            }
            else if (resta == true && coma == false && suma == false)
            {
                Form1.Reset();
                resultado.Text = string.Empty;
                valor2 = resultado.Text + n;
                decima = valor2;
                coma = true;


            }
            else if (potenciaxy == true)

            {
                
                resultado.Text = string.Empty;
                valor2 = resultado.Text + n;
                decima = valor2;
            }

           
            
            resultado.Text = resultado.Text + n;
            


        }
    }
}
