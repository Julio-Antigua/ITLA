using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClculadoraDU
{
    public partial class Calculadora : Form
    {
        double primero;
        double segundo;
        string operador;
        public Calculadora()
        {
            InitializeComponent();
        }
        Suma obj = new Suma();
        Resta obj2 = new Resta();
        Multiplica obj3 = new Multiplica();
        Division obj4 = new Division();
        private void btnN0_Click(object sender, EventArgs e)
        {
            txtIntroducir.Text = txtIntroducir.Text + "0";
        }

        private void btnN1_Click(object sender, EventArgs e)
        {
            txtIntroducir.Text = txtIntroducir.Text + "1";
        }

        private void btnN2_Click(object sender, EventArgs e)
        {
            txtIntroducir.Text = txtIntroducir.Text + "2";
        }

        private void btnN3_Click(object sender, EventArgs e)
        {
            txtIntroducir.Text = txtIntroducir.Text + "3";
        }

        private void btnN4_Click(object sender, EventArgs e)
        {
            txtIntroducir.Text = txtIntroducir.Text + "4";
        }

        private void btnN5_Click(object sender, EventArgs e)
        {
            txtIntroducir.Text = txtIntroducir.Text + "5";
        }

        private void btnN6_Click(object sender, EventArgs e)
        {
            txtIntroducir.Text = txtIntroducir.Text + "6";
        }

        private void btnN7_Click(object sender, EventArgs e)
        {
            txtIntroducir.Text = txtIntroducir.Text + "7";
        }

        private void btnN8_Click(object sender, EventArgs e)
        {
            txtIntroducir.Text = txtIntroducir.Text + "8";
        }

        private void btnN9_Click(object sender, EventArgs e)
        {
            txtIntroducir.Text = txtIntroducir.Text + "9";
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            txtIntroducir.Text = txtIntroducir.Text + ".";
        }

        private void Calculadora_Load(object sender, EventArgs e)
        {

        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            operador = "+";
            primero = double.Parse(txtIntroducir.Text);
            txtIntroducir.Clear();
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            operador = "-";
            primero = double.Parse(txtIntroducir.Text);
            txtIntroducir.Clear();
        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            operador = "*";
            primero = double.Parse(txtIntroducir.Text);
            txtIntroducir.Clear();
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            operador = "/";
            primero = double.Parse(txtIntroducir.Text);
            txtIntroducir.Clear();
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            segundo = double.Parse(txtIntroducir.Text);

            double SUM;
            double RES;
            double MUL;
            double DIV;

            switch(operador)
            {
                case "+":
                    SUM = obj.Sumar((primero), (segundo));
                    txtIntroducir.Text = SUM.ToString();
                    break;

                case "-":
                    RES = obj2.Restar((primero), (segundo));
                    txtIntroducir.Text = RES.ToString();
                    break;

                case "*":
                    MUL = obj3.Multiplicar((primero), (segundo));
                    txtIntroducir.Text = MUL.ToString();
                    break;

                case "/":
                    DIV = obj4.Dividir((primero), (segundo));
                    txtIntroducir.Text = DIV.ToString();
                    break;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtIntroducir.Clear();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (txtIntroducir.Text.Length == 1)
                txtIntroducir.Text = "";
            else
                txtIntroducir.Text = txtIntroducir.Text.Substring(0, txtIntroducir.Text.Length - 1);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
           this.Close();
        }
    }
}
