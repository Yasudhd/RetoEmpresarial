using System;
using System.Collections.Generic;
using System.Text;

namespace RetoEmpresarial
{
    public class Descuento
    {
        private string nombre;
        private double descuento;
        private DateTime fechaInicio;
        private DateTime fechaFin;

        public Descuento(string nombre, double descuento, DateTime fechaInicio, DateTime fechaFin)//Solo guarda nombre, porcentaje y las fechas de inicio y fin
        {
            this.nombre = nombre;
            this.descuento = descuento;
            this.fechaInicio = fechaInicio;
            this.fechaFin = fechaFin;
        }
    }
}
