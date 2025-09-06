using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO_Avanzada_forms
{
    public partial class Form1 : Form
    {
        Biblioteca miBiblioteca = new Biblioteca();
        Libro miLibro = new Libro();
        Usuario miUsuario = new Usuario();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dtpFechaDeDevolucion.MinDate = DateTime.Today;
            MessageBox.Show(
       "📘 Bienvenido al sistema de Biblioteca\n\n" +
       "👉 Sigue estos pasos para usar el programa:\n\n" +
       "1. Ingresa el NOMBRE y el ID del usuario.\n" +
       "2. Ingresa el TÍTULO, AUTOR e ISBN del libro.\n" +
       "3. Selecciona la FECHA DE DEVOLUCION.\n" +
       "4. Da clic en AGREGAR para registrar.\n" +
       "5. Da clic en PRESTAR para hacer el préstamo.\n" +
       "6. Da clic en DEVOLVER cuando se regrese el libro.\n\n" +
       "✅ ¡Listo! Puedes comenzar.",
       "Instrucciones de Uso",
       MessageBoxButtons.OK,
       MessageBoxIcon.Information
   );
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
            miUsuario.Id = int.Parse(txtId.Text);
            miUsuario.Nombre = txtNombre.Text;

            
            miLibro.Titulo = txtTitulo.Text;
            miLibro.Autor = txtAutor.Text;
            miLibro.ISBN = int.Parse(txtISBN.Text);

            
            miBiblioteca.FechaPrestamo = DateTime.Today;
            miBiblioteca.FechaDevolucion = dtpFechaDeDevolucion.Value;

            
            MessageBox.Show(
                "ID del usuario: " + miUsuario.Id + "\nNombre del usuario: " + miUsuario.Nombre + "\nTítulo del libro: " + miLibro.Titulo + "\nAutor del libro: " + miLibro.Autor +
                "\nISBN del libro: " + miLibro.ISBN +
                "\nFecha del préstamo: " + miBiblioteca.FechaPrestamo.ToShortDateString() +
                "\nFecha de devolución: " + miBiblioteca.FechaDevolucion.ToShortDateString(),
                "Información del préstamo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            foreach (Control x in groupBoxUsuario.Controls)
                if (x is TextBox) x.Text = "";
            foreach (Control x in groupBoxLibro.Controls)
                if (x is TextBox) x.Text = "";
        }

        private void btnPrestar_Click(object sender, EventArgs e)
        {
            miBiblioteca.Prestar(miLibro, miUsuario);
            MessageBox.Show("Prestamo registrado en consola.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDevolver_Click(object sender, EventArgs e)
        {
            miBiblioteca.Devolver(miLibro, miUsuario);
            MessageBox.Show("Devolucin registrada en consola.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
