using System;
using System.Collections.Generic;
using System.Text;

namespace RetoEmpresarial
{
    public abstract class Consulta
    {
        protected double precio;
        protected int duracionMinutos;

        public Consulta(double precio, int duracionMinutos)
        {
            this.precio = precio;
            this.duracionMinutos = duracionMinutos;
        }

        public abstract double CalcularCosto();//es abstracto: cada hija lo calcula distinto so toca revisar las hijas
        public void CambiarPrecio(double nuevoPrecio) { precio = nuevoPrecio; }//lo usa el administrador pa cambiar el precio
    }
}
