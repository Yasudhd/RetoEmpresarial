using System;
using System.Collections.Generic;
using System.Text;

namespace RetoEmpresarial
{
    public class ServicioAdicional
    {
        private string nombre;
        private double costo;

        public ServicioAdicional(string nombre, double costo)
        {
            this.nombre = nombre;
            this.costo = costo;
        }

        public double ObtenerCosto()//devuelve el costo (esto lit existe porque costo es privado y Cita necesita leerlo)
        {
            return costo;
        }
    }
}
