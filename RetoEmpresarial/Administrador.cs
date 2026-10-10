using System;
using System.Collections.Generic;
using System.Text;

namespace RetoEmpresarial
{
    public class Administrador : Empleado
    {
        private List<Descuento> descuentos = new List<Descuento>();

        public Administrador(string nombre, string documento, long telefono, string correo,
                             string ID, string contraseña)
            : base(nombre, documento, telefono, correo, ID, contraseña) { }

        public void ModificarCostoConsulta(Consulta c, double nuevoPrecio)//cambia el precio base de una consulta y ya
        {
            c.CambiarPrecio(nuevoPrecio);
        }

        public Reporte GenerarReporte(TipoReporte tipo, string periodo)//crea y devuelve un reporte
        {
            return new Reporte(tipo, periodo);
        }

        public void GestionarDescuento(Descuento p)// agrega un descuento a su lista
        {
            descuentos.Add(p);
        }
    }
}
