using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase_Coche_Forms
{
    internal class Coche
    {
        private string _strMarca;
        private string _strModelo;
        private double _dblVelocidad;

        public string Marca
        {
            get { return _strMarca; }
            set { _strMarca = value; }
        }
        public string Modelo
        {
            get { return _strModelo; }
            set { _strModelo = value; }
        }
        public double Velocidad
        {
            get { return _dblVelocidad; }
            set { _dblVelocidad = value; }
        }
        public Coche(string marca, string modelo)
        {
            Marca = marca;
            Modelo = modelo;
            Velocidad = 0;
        }

        public string Acelerar(double incremento)
        {
            Velocidad += incremento;
            return $"{Marca} {Modelo} aceleró a {Velocidad} km/h";
        }

        public string Frenar(double decremento)
        {
            Velocidad -= decremento;
            if (Velocidad < 0) Velocidad = 0;
            return $"{Marca} {Modelo} frenó a {Velocidad} km/h";
        }
        public string MostrarVelocidad()
        {
            return ("Velocidad actual: " + Velocidad + "km/h");
        }

        ~Coche()
        {
             MessageBox.Show($"{Marca} {Modelo} se ha destruido", "Destructor",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
