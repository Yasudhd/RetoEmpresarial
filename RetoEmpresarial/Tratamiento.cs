using System;
using System.Collections.Generic;
using System.Text;

namespace RetoEmpresarial
{
    public class Tratamiento
    {
        private string descripcion;
        private int duracionDias;
        private List<Medicamento> medicamentos = new List<Medicamento>();

        public Tratamiento(string descripcion, int duracionDias)
        {
            this.descripcion = descripcion;
            this.duracionDias = duracionDias;
        }

        public void AgregarMedicamento(Medicamento m)//agrega un medicamento a ese tratamiento
        {
            medicamentos.Add(m);
        }
    }
}
