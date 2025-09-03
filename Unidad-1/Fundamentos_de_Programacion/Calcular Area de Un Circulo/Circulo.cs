using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcular_Area_de_Un_Circulo
{
    internal class Circulo
    {
        public double _dblRadio;

        public double Radio
        {
            get { return _dblRadio; }
            set { _dblRadio = value; }
        }
        public double Area()
        {
            return Math.PI * Math.Pow(_dblRadio, 2);
        }
    }
}
