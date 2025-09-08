using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_En_Clase_8_sep._2025_Ed
{
    internal class Cuadrado : Rectangulo
    {
        public Cuadrado(double lado) : base(lado, lado)
        {
            lado = Ancho;
        }
        public Cuadrado(double ancho, double alto) : base(ancho, alto)
        {
           
        }

    }
}
