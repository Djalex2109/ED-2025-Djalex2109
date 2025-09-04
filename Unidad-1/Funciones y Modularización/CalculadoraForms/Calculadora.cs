using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraForms
{
    internal class Calculadora
    {
        public double A;
        public double B;
        public double Resultado;

        public double ImprimeSUMA()
        {
            double Suma;
            return Suma = A + B;

        }
        public double ImprimeRESTA()
        {
            double Resta;
            return Resta = A - B;
        }
        public double ImprimeMULTIPLICACION()
        {
            double Multi;
            return Multi = A * B;
        }
        public double ImprimeDIVISION()
        {
            if (B != 0)
            {
                return A / B;
            }
            else
            {
                MessageBox.Show("No se puede dividir entre 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0; 
            }
        }
    }
}