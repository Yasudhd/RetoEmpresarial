using System;
using System.Collections.Generic;
using System.Text;

namespace RetoEmpresarial
{
    public class Recepcionista : Empleado
    {
        public Recepcionista(string nombre, string documento, long telefono, string correo,
                             string ID, string contraseña)
            : base(nombre, documento, telefono, correo, ID, contraseña) { }

      
        public Cita RegistrarCitaPresencial(Cliente cliente, Mascota m, Consulta c) //le pide al cliente que agende una cita con la fecha de hoy y la devuelve.
        {
            return cliente.AgendarCita(m, c, DateTime.Now);
        }

        public void ModificarConsultorio(Cita cita, int nuevoConsultorio)//busca el veterinario asignado a la cita y le cambia el número de consultorio pero si la cita no tiene veterinario no hace na
        {
            Veterinario v = cita.ObtenerVeterinario();
            if (v != null)
                v.CambiarConsultorio(nuevoConsultorio);
        }

        public bool CancelarCita(Cita cita)//pone el estado de la cita en "Cancelada" y devuelve false si la cita es null
        {
            if (cita == null) return false;
            cita.CambiarEstado("Cancelada");
            return true;
        }

        public void FinalizarAtencion(Cita cita)//pone el estado de la cita en "Finalizada"
        {
            cita.CambiarEstado("Finalizada");
        }
    }
}
