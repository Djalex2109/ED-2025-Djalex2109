using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase_Libro_Forms
{
    public partial class Form1 : Form
    {
        Libro miLibro = new Libro("La Divina Comedia", " Dante Alighieri");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCrearLibro_Click(object sender, EventArgs e)
        {
            miLibro.Titulo = txtTitulo.Text;
            miLibro.Autor = txtAutor.Text;
            MessageBox.Show("El libro fue creado", "Libro nuevo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtTitulo.Clear();
            txtAutor.Clear();
        }

        private void btnInformacion_Click(object sender, EventArgs e)
        {
            MessageBox.Show(miLibro.ToString(), "Informacion del libro", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
