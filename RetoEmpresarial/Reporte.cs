using System;
using System.Collections.Generic;
using System.Text;

namespace RetoEmpresarial
{
    public class Reporte
    {
        private TipoReporte tipo;
        private string periodo;

        public Reporte(TipoReporte tipo, string periodo)
        {
            this.tipo = tipo;
            this.periodo = periodo;
        }

        public void Generar()//imprime una línea con el tipo y el periodo de tiempo
        {
            Console.WriteLine($"Reporte de {tipo} del periodo {periodo}");
        }
    }
}
