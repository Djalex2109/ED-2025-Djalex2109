using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_En_Clase_8_sep._2025_Ed
{
    internal class Rectangulo
    {
        private double _dblAncho;
        private double _dblAlto;

        public double Ancho
        {
            get { return _dblAncho; }
            set { _dblAncho = value; }
        }
        public double Alto
        {
            get { return _dblAlto; }
            set { _dblAlto = value; }
        }

        public Rectangulo(double dblAncho, double dblAlto)
        {
            _dblAncho = dblAncho;
            _dblAlto = dblAlto;
        }

        public double MostrarArea()
        {
            return _dblAncho * _dblAlto;
        }
        public double MostrarPerimetro()
        {
            return 2 * (_dblAncho + _dblAlto);
        }
        public string MostrarDimensiones()
        {
            return $"Ancho: {_dblAncho}, Alto: {_dblAlto}";
        }
    }
}
