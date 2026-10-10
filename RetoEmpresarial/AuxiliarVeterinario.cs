using System;
using System.Collections.Generic;
using System.Text;

namespace RetoEmpresarial
{
    public class AuxiliarVeterinario : Empleado
    {
        public AuxiliarVeterinario(string nombre, string documento, long telefono, string correo,
                                   string ID, string contraseña)
            : base(nombre, documento, telefono, correo, ID, contraseña) { }

        public void RegistrarSignosVitales(Mascota m, double peso, double temp)  // actualiza el peso de la mascota e imprime la temperatura
        {
            m.ActualizarPeso(peso);
            Console.WriteLine("Temperatura registrada: " + temp);
        }

        public void AdministrarTratamiento(Mascota m, Tratamiento t)//agrega un tratamiento a la historia de la mascota 
        {
            m.ObtenerHistoria().AgregarTratamiento(t);
        }

        public void GestionarInsumos(Insumo i, int cantidad)//suma (o resta, si el numero es negativo) unidades al inventario de un insumo
        {
            i.ActualizarInventario(cantidad);
        }

        public void PrepararConsultorio(Consulta c)//solo imprime que el consultorio está listo bastante simple 
        {
            Console.WriteLine("Consultorio preparado para la consulta");
        }
    }
}
