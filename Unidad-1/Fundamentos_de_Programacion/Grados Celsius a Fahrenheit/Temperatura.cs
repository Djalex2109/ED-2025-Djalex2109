using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grados_Celsius_a_Fahrenheit
{
    internal class Temperatura
    {
        private double _dblCelsius;

        public double Celsius
        {
            get { return _dblCelsius; }
            set { _dblCelsius = value; }
        }
        public double ConvertirAFahrenheit()
        {
            return (_dblCelsius * 9 / 5) + 32;
        }
    }
}