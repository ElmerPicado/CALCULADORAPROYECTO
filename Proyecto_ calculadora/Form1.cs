using System.Diagnostics.CodeAnalysis;
using System.DirectoryServices.ActiveDirectory;
using System.Numerics;
using System.Threading.Tasks.Sources;
using System.Web;
using Proyecto_calculadora;

namespace Proyecto__calculadora
{
    public partial class Form1 : Form
    {
        static float num1, num2 = 0;
        static string valor2 = "";
        static string n = string.Empty;
        static string decima = "";
        static float total = 0;
        static bool suma, resta, coma, limpiar, potenciaxy, masmenos, multiplicacion, division = false;

        public Form1()
        {
            InitializeComponent();
        }

        public static void Reset()
        {

            valor2 = "";
            num2 = 0;
            total = 0;
        }
        public void Limpiar()
        {

            valor2 = "";
            num2 = 0;
            total = 0;
            num1 = 0;
            n = string.Empty;
            decima = "";
            total = 0;
            resta = false;
            suma = false;
            potenciaxy = false;
            masmenos = false;
            multiplicacion = false;
            division = false;
            limpiar = false;
            coma = false;
        }
        public void valor0()


        {

            if (Lresultado.Text == "0")
            {
                Lresultado.Text = string.Empty;
            }
            if (acumulado.Text == "0")
            {
                acumulado.Text = string.Empty;
            }

        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Lresultado.Text = string.Empty;
            acumulado.Text= string.Empty;
        }






        private void b_1_Click(object sender, EventArgs e)
        {
            n = "1";
            limpiar = true; valor0();
            Lresultado.Text = Lresultado.Text + n;
            acumulado.Text = acumulado.Text + n;
        }
        private void b_2_Click(object sender, EventArgs e)
        {
            n = "2";
            limpiar = true; valor0();
            Lresultado.Text = Lresultado.Text + n;
            acumulado.Text = acumulado.Text + n;
        }
        private void b_3_Click(object sender, EventArgs e)
        {
            limpiar = true; valor0();
            n = "3";
            Lresultado.Text = Lresultado.Text + n;
            acumulado.Text = acumulado.Text + n;
        }
        private void b_4_Click(object sender, EventArgs e)
        {
            limpiar = true; valor0();
            n = "4";
            Lresultado.Text = Lresultado.Text + n;
            acumulado.Text = acumulado.Text + n;
        }
        private void b_5_Click(object sender, EventArgs e)
        {
            limpiar = true; valor0();
            n = "5";
            Lresultado.Text = Lresultado.Text + n;
            acumulado.Text = acumulado.Text + n;
        }

        private void b_6_Click(object sender, EventArgs e)
        {
            limpiar = true; valor0();
            n = "6";
            Lresultado.Text = Lresultado.Text + n;
            acumulado.Text = acumulado.Text + n;
        }

        private void b_7_Click(object sender, EventArgs e)

        {
            limpiar = true; valor0();
            n = "7";
            Lresultado.Text = Lresultado.Text + n;
            acumulado.Text = acumulado.Text + n;
        }
        private void b_8_Click(object sender, EventArgs e)
        {
            limpiar = true; valor0();
            n = "8";
            Lresultado.Text = Lresultado.Text + n;
            acumulado.Text = acumulado.Text + n;
        }
        private void b_9_Click(object sender, EventArgs e)
        {
            limpiar = true; valor0();
            n = "9";
            Lresultado.Text = Lresultado.Text + n;
            acumulado.Text = acumulado.Text + n;
        }
        private void b_0_Click(object sender, EventArgs e)
        {
            limpiar = true; valor0();
            n = "0";
            Lresultado.Text = Lresultado.Text + n;
            acumulado.Text = acumulado.Text + n;
        }

        private void b_coma_Click(object sender, EventArgs e)

        {
            Lresultado.Text = Lresultado.Text + ",";
            acumulado.Text = acumulado.Text + ",";
            decima = Lresultado.ToString();
            coma = true;

        }
        private void b_Borrar_Click(object sender, EventArgs e)
        {
            num1 = 0;
            num2 = 0;
            Lresultado.Text = "0";
            acumulado.Text = "0";
            suma = false;
            resta = false;
            multiplicacion = false;
            division = false;
            potenciaxy = false;

        }

        private void b_mas_Click(object sender, EventArgs e)
        {

            num1 = float.Parse(Lresultado.Text);
            Lresultado.Text = string.Empty;
            acumulado.Text = acumulado.Text + "+";
            suma = true;
        }


        private void b_igual_Click(object sender, EventArgs e)
        {
            num2 = float.Parse(Lresultado.Text);
            Lresultado.Text = string.Empty;
            Lresultado.Text = Convert.ToString(FuncionIgual.Operacion(num1, num2, suma, resta, multiplicacion, division, potenciaxy));
        }

        public static void Lresultado_Click(object sender, EventArgs e)

        {


        }


        private void b_diferencial_Click_1(object sender, EventArgs e)
        {

            num1 = float.Parse(Lresultado.Text);
            Lresultado.Text = Factorial.factorial(num1).ToString();
            acumulado.Text = $"fact({num1})";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            num1 = int.Parse(Lresultado.Text);
            Lresultado.Text = string.Empty;
            acumulado.Text = acumulado.Text + "-";
            resta = true;


        }

        private void b_Raiz_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(Lresultado.Text);
            Lresultado.Text = Raiz.RaizCuadrada(num1).ToString();
            acumulado.Text = $"√({num1})";
        }

        private void b_x2_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(Lresultado.Text);
            Lresultado.Text = Potencia.PotenciaAlCuadrado(num1).ToString();
            acumulado.Text = $"sqr({num1})";
        }

        private void b_elevadox_Click(object sender, EventArgs e)
        {
            num1 = int.Parse(Lresultado.Text);
            Lresultado.Text = string.Empty;
            acumulado.Text = acumulado.Text + "^";
            potenciaxy = true;

        }

        private void b_masmenos_Click(object sender, EventArgs e)
        {
            int num3 = 0;
            num3 = int.Parse(Lresultado.Text);
            num3 = num3 * -1;

            Lresultado.Text = num3.ToString();
            acumulado.Text = acumulado.Text + num3.ToString();
        }

        private void b_multiplicar_Click(object sender, EventArgs e)
        {
            num1 = int.Parse(Lresultado.Text);
            Lresultado.Text = string.Empty;
            acumulado.Text = acumulado.Text + "x";
            multiplicacion = true;
        }

        private void b_Dividir_Click(object sender, EventArgs e)
        {
            num1 = int.Parse(Lresultado.Text);
            Lresultado.Text = string.Empty;
            acumulado.Text = acumulado.Text + "/";
            division = true;
        }

        private void acumulado_Click(object sender, EventArgs e)
        {
            acumulado.Text = string.Empty;
        }

        private void b_10x_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(Lresultado.Text);
            Lresultado.Text = Elevado.diezElevado(num1).ToString();
            acumulado.Text = $"10^({num1})";
        }

        private void b_log_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(Lresultado.Text);
            Lresultado.Text = Logaritmo.principal(num1).ToString();
            acumulado.Text = $"log({num1})";
        }
    }
} 
