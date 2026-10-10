using System;
using System.Collections.Generic;
using System.Text;

namespace RetoEmpresarial
{
    public class Insumo
    {
        private string nombre;
        private int cantidad;
        private TipoInsumo tipo;

        public Insumo(string nombre, int cantidad, TipoInsumo tipo)
        {
            this.nombre = nombre;
            this.cantidad = cantidad;
            this.tipo = tipo;
        }

        public void ActualizarInventario(int cantidad)
        {
            this.cantidad += cantidad;   //suma esa cantidad al inventario.
        }
    }
}
