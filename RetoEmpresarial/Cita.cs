using System;
using System.Collections.Generic;
using System.Text;

namespace RetoEmpresarial
{
    public class Cita
    {
        private string codigoCita;
        private DateTime fecha;
        private string estado;
        private Mascota mascota;
        private Consulta consulta;
        private List<ServicioAdicional> servicios = new List<ServicioAdicional>();

        public Cita(string codigoCita, DateTime fecha, Mascota mascota, Consulta consulta)
        {
            this.codigoCita = codigoCita;
            this.fecha = fecha;
            this.estado = "Pendiente";
            this.mascota = mascota;
            this.consulta = consulta;
        }
        private Veterinario veterinario;

        public string ObtenerCodigo() { return codigoCita; }//devuelve el código
        public void CambiarEstado(string nuevoEstado) { estado = nuevoEstado; }//cambia el estado (Pendiente, Cancelada, Finalizada)
        public void AsignarVeterinario(Veterinario v) { veterinario = v; }//guarda y devuelve el veterinario de la cita
        public Veterinario ObtenerVeterinario() { return veterinario; }//guarda y devuelve el veterinario de la cita
        public void AgregarServicio(ServicioAdicional s)//agrega un servicio adicional
        {
            servicios.Add(s);
        }

        public double CalcularCosto()// costo de la consulta más el costo de cada servicio adicional
        {
            double total = consulta.CalcularCosto();
            foreach (ServicioAdicional s in servicios)
            {
                total += s.ObtenerCosto();
            }
            return total;
        }
        public override string ToString()//muestra codigo, fecha y estado.
        {
            return $"Cita {codigoCita} | {fecha:dd/MM/yyyy HH:mm} | Estado: {estado}";
        }
    }
}
