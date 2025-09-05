using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase_Libro_Forms
{
    internal class Libro
    {
        private string _strTitulo;
        private string _strAutor;

        public string Titulo
        {
            get { return _strTitulo; }
            set { _strTitulo = value; }
        }
        public string Autor
        {
            get { return _strAutor; }
            set { _strAutor = value; }
        }
        public Libro(string strTitulo, string strAutor)
        {
            _strTitulo = strTitulo;
            _strAutor = strAutor;
        }
        public override string ToString()
        {
            return ("Titulo del libro: " + Titulo + "\nNombre del autor: " + Autor);
        }
        ~Libro()
        {            
            MessageBox.Show($"El libro '{Titulo}' de {Autor} se ha destruido",
                "Destructor", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
