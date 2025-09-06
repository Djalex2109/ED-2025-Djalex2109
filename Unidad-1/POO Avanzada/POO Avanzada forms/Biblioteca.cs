using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Avanzada_forms
{
    internal class Biblioteca
    {
        private DateTime _dtmFechaPrestamo;
        private DateTime _dtmFechaDevolucion;

        public DateTime FechaPrestamo
        {
            get { return _dtmFechaPrestamo; }
            set { _dtmFechaPrestamo = value; }
        }
        public DateTime FechaDevolucion
        {
            get { return _dtmFechaDevolucion; }
            set { _dtmFechaDevolucion = value; }
        }

        public void Prestar(Libro strlibro, Usuario strusuario)
        {
            FechaPrestamo = DateTime.Now;
            FechaDevolucion = FechaPrestamo.AddDays(7); 
            Console.WriteLine($"{strusuario.Nombre} ha prestado '{strlibro.Titulo}'");
            Console.WriteLine($"Fecha de devolución: {FechaDevolucion.ToShortDateString()}");
        }
        public void Devolver(Libro strlibro, Usuario strusuario)
        {
            FechaPrestamo = DateTime.MinValue;
            FechaDevolucion = DateTime.MinValue;
            Console.WriteLine($"{strusuario.Nombre} ha devuelto '{strlibro.Titulo}'");
        }
    }
}
