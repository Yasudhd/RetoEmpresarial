using System;
using System.Collections.Generic;
using System.Text;

namespace RetoEmpresarial
{
    public class ConsultaUrgencias : Consulta
    {
        public ConsultaUrgencias(double precio, int duracionMinutos)
            : base(precio, duracionMinutos) { }

        public override double CalcularCosto()//precio por 2 pues pq es urgencia y aja
        {
            return precio * 2;  
        }
    }
}
