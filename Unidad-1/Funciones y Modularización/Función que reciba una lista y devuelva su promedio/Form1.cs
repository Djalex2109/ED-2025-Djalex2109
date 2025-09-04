using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Función_que_reciba_una_lista_y_devuelva_su_promedio
{
    public partial class Form1 : Form
    {
        double Numero;
        double Promedio;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregarNumero_Click(object sender, EventArgs e)
        {
            Numero = Convert.ToDouble(txtNumero.Text);
            listaNumeros.Items.Add(Numero);
            txtNumero.Clear();
        }

        private void btnPromedio_Click(object sender, EventArgs e)
        {
            List<double> Numeros = new List<double>();

            foreach (var item in listaNumeros.Items)
            {
                Numeros.Add(Convert.ToDouble(item));
            }
            Promedio = CalcularPromedio(Numeros);
            MessageBox.Show("Promedio de la lista: " + Promedio, "Promedio", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private double CalcularPromedio(List<double> numeros)
        {
            double Suma = 0;
            foreach (double n in numeros)
            {
                Suma += n;
            }
            return Suma / numeros.Count;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
