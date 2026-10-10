using System;
using System.Collections.Generic;
using System.Text;

namespace RetoEmpresarial
{
    public class ConsultaEspecializada : Consulta
    {
        private Especialidad especialidadRequerida;
        //precio por 1.5 (50% más) y de paso guarda la especialidad requerida.
        public ConsultaEspecializada(double precio, int duracionMinutos, Especialidad especialidadRequerida)
            : base(precio, duracionMinutos)
        {
            this.especialidadRequerida = especialidadRequerida;
        }

        public override double CalcularCosto()
        {
            return precio * 1.5;
        }
    }
}
