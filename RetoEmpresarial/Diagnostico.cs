using System;
using System.Collections.Generic;
using System.Text;

namespace RetoEmpresarial
{
    public class Diagnostico
    {
        private DateTime fecha;
        private string descripcion;
        private string recomendaciones;

        public Diagnostico(DateTime fecha, string descripcion, string recomendaciones)
        {
            this.fecha = fecha;
            this.descripcion = descripcion;
            this.recomendaciones = recomendaciones;
        }
        public override string ToString()
        {
            return $"{fecha:dd/MM/yyyy} - {descripcion}";
        }
    }
}
