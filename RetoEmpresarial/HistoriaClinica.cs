using System;
using System.Collections.Generic;
using System.Text;

namespace RetoEmpresarial
{
    public class HistoriaClinica
    {
        private List<Diagnostico> diagnosticos = new List<Diagnostico>();
        private List<Tratamiento> tratamientos = new List<Tratamiento>();

        public void AgregarDiagnostico(Diagnostico d)//meten un elemento a su lista
        {
            diagnosticos.Add(d);
        }

        public void AgregarTratamiento(Tratamiento t)//meten un elemento a su lista 
        {
            tratamientos.Add(t);
        }

        public List<Diagnostico> ConsultarHistorial()// devuelve la lista de diagnósticos
        {
            return diagnosticos;
        }
    }
}
