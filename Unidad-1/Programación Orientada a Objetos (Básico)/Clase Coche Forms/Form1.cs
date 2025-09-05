using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase_Coche_Forms
{
    public partial class Form1 : Form
    {
        Coche miCoche = new Coche("Porshe", "GT3 RS ");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAcelerar_Click(object sender, EventArgs e)
        {
            miCoche.Acelerar(20); // acelera de 20 en 20
            lblVelocidad.Text = $"{miCoche.Marca} {miCoche.Modelo} va a {miCoche.Velocidad} km/h";
        }

        private void btnFrenar_Click(object sender, EventArgs e)
        {
            miCoche.Frenar(20); // frena de 20 en 20
            lblVelocidad.Text = $"{miCoche.Marca} {miCoche.Modelo} va a {miCoche.Velocidad} km/h";
        }
    }
}
