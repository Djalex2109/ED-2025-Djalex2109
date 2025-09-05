using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase_Coche_Forms
{
    public partial class Form1 : Form
    {
        private Coche miCoche;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAcelerar_Click(object sender, EventArgs e)
        {
            if (miCoche == null)
            {
                MessageBox.Show("Primero crea el auto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!double.TryParse(btnAcelerar.Text, out double incremento))
            {
                incremento = 10; 
            }

            miCoche.Acelerar(incremento);
            lblVelocidad.Text = miCoche.MostrarVelocidad();
        }

        private void btnFrenar_Click(object sender, EventArgs e)
        {
            if (miCoche == null)
            {
                MessageBox.Show("Primero crea el auto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!double.TryParse(btnFrenar.Text, out double decremento))
            {
                decremento = 10; // valor por defecto
            }

            miCoche.Frenar(decremento);
            lblVelocidad.Text = miCoche.MostrarVelocidad();
        }


        private void btnCrear_Click(object sender, EventArgs e)
        {
            string marca = txtMarca.Text;
            string modelo = txtModelo.Text;

            if (!double.TryParse(txtVelocidad.Text, out double velocidad))
            {
                MessageBox.Show("Ingresa un valor numérico válido para la velocidad.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            miCoche = new Coche(marca, modelo);
            miCoche.Velocidad = velocidad;

            lblVelocidad.Text = miCoche.MostrarVelocidad(); 
            MessageBox.Show($"Auto {marca} {modelo} creado con velocidad {velocidad} km/h", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}