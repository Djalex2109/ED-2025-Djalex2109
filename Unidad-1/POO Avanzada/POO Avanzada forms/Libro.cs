using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Avanzada_forms
{
    internal class Libro
    {
        private string _strTitulo;
        private string _strAutor;
        private int _strISBN;

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
        public int ISBN
        {
            get { return _strISBN; }
            set { _strISBN = value; }
        }
    }
}
