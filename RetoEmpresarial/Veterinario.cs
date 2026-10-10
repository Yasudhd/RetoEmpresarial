using System;
using System.Collections.Generic;
using System.Text;

namespace RetoEmpresarial
{
    public class Veterinario : Empleado
    {
        private Especialidad especialidad;
        private int numeroConsultorio;
        private bool disponible;

        public Veterinario(string nombre, string documento, long telefono, string correo,
                           string ID, string contraseña,
                           Especialidad especialidad, int numeroConsultorio)
            : base(nombre, documento, telefono, correo, ID, contraseña)
        {
            this.especialidad = especialidad;
            this.numeroConsultorio = numeroConsultorio;
            this.disponible = true;
        }

        public HistoriaClinica ConsultarHistoriaClinica(Mascota m)//devuelve la historia clínica de la mascota y ya
        {
            return m.ObtenerHistoria();
        }

        public Diagnostico RegistrarDiagnostico(Mascota m, string desc)//aca secrea un diagnóstico con la fecha  y lo guarda en la historia de la mascota
        {
            Diagnostico d = new Diagnostico(DateTime.Now, desc, "");
            m.ObtenerHistoria().AgregarDiagnostico(d);
            return d;
        }

        public string PrescribirMedicamento(Mascota m, Medicamento med)//se crea un tratamiento tmb le agrega el medicamento y lo guarda en la historia luego devuelve un texto de confirmación tal
        {
            Tratamiento t = new Tratamiento("Medicamento prescrito", 0);
            t.AgregarMedicamento(med);
            m.ObtenerHistoria().AgregarTratamiento(t);
            return "Medicamento prescrito";
        }

        public void SolicitarExamen(Mascota m, string tipo)// solo imprime el examen solicitado 
        {
            Console.WriteLine("Examen solicitado: " + tipo);
        }

        public bool ActualizarEstadoSalud(Mascota m, string estado)//este cambia el estado de salud de la mascota y devuelve true
        {
            m.CambiarEstadoSalud(estado);
            return true;
        }

        public bool VerificarDisponibilidad()//devuelve si el veterinario está disponible y ya
        {
            return disponible;
        }

        public void CambiarConsultorio(int nuevoConsultorio) //cambia su número de consultorio (lo usa el Recepcionista)
        {
            numeroConsultorio = nuevoConsultorio;
        }
    }
}
