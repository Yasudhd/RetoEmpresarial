using System;
using System.Collections.Generic;
using System.Text;

namespace RetoEmpresarial
{
    public class Medicamento
    {
        private string nombre;
        private string dosis;
        private int duracionDias;

        public Medicamento(string nombre, string dosis, int duracionDias)//Solo se guarda nombre, dosis y duración en días 
        {
            this.nombre = nombre;
            this.dosis = dosis;
            this.duracionDias = duracionDias;
        }

    }
}
