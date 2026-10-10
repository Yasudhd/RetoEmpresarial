using System;
using System.Collections.Generic;
using System.Text;

namespace RetoEmpresarial
{
    public class Cliente : Persona
    {
       
        private List<Mascota> mascotas = new List<Mascota>();

        public Cliente(string nombre, string documento, long telefono, string correo)
            : base(nombre, documento, telefono, correo) { }

        //esto es  para agregar mascotas a la lista
        public void AgregarMascota(Mascota m)
        {
            mascotas.Add(m);
        }

        
        public Cita AgendarCita(Mascota m, Consulta c, DateTime fecha)// aca se crea y devuelve una cita nueva para esa mascota  con esa consulta(C001) y la fecha 
        {
            return new Cita("C001", fecha, m, c);
        }
    }
}
