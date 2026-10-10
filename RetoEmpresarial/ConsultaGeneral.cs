using System;
using System.Collections.Generic;
using System.Text;

namespace RetoEmpresarial
{

    public class ConsultaGeneral : Consulta
    {
        //esta cuesta el precio base.
        public ConsultaGeneral(double precio, int duracionMinutos)
            : base(precio, duracionMinutos) { }

        public override double CalcularCosto()
        {
            return precio;
        }
    }
}
