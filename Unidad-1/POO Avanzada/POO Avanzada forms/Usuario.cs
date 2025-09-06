using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Avanzada_forms
{
    internal class Usuario
    {
        private string _strNombre;
        private int _intId;

        public string Nombre
        {
            get { return _strNombre; }
            set { _strNombre = value; }
        }
        public int Id
        {
            get { return _intId; }
            set { _intId = value; }
        }
    }
}
