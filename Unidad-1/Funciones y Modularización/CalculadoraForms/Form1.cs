using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraForms
{
    public partial class Form1 : Form
    {
        Calculadora miCalculadora = new Calculadora();
        string operador;
        int Pilas = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "1"; 

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "0";
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            miCalculadora.A = double.Parse(txtResultado.Text); 
            operador = "/";
            txtResultado.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text.Length > 1)
            {
                txtResultado.Text = txtResultado.Text.Substring(0, txtResultado.Text.Length - 1);
            }
            else
            {
                txtResultado.Text = "";
            }
        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            miCalculadora.A = double.Parse(txtResultado.Text);
            operador = "*";
            txtResultado.Clear();
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            miCalculadora.A = double.Parse(txtResultado.Text);
            operador = "-";
            txtResultado.Clear();
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            miCalculadora.A = double.Parse(txtResultado.Text);
            operador = "+";
            txtResultado.Clear();
        }

        private void txtResultado_TextChanged(object sender, EventArgs e)
        {

        }
        private void Operador_Click(object sender, EventArgs e)
        {

        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            miCalculadora.B = double.Parse(txtResultado.Text);
            double resultado = 0;

            switch (operador)
            {
                case "+": resultado = miCalculadora.ImprimeSUMA(); break;
                case "-": resultado = miCalculadora.ImprimeRESTA(); break;
                case "*": resultado = miCalculadora.ImprimeMULTIPLICACION(); break;
                case "/": resultado = miCalculadora.ImprimeDIVISION(); break;
                   
            }

            txtResultado.Text = resultado.ToString();
        }

        private void btnOnOff_Click(object sender, EventArgs e)
        {
            if (Pilas == 1)
            {
                Pilas = 0;
                txtResultado.Visible = true;
                txtResultado.Text = "";
            }
            else
            {
                Pilas = 1;
                txtResultado.Visible = false;
                txtResultado.Text = "";
            }
        }
        

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
            miCalculadora.A = 0;
            miCalculadora.B = 0;

        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            if (!txtResultado.Text.Contains("."))
            {
                txtResultado.Text += ".";
            }
        }
    }
}
