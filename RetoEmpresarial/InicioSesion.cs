using System;
using System.Collections.Generic;
using System.Text;

namespace RetoEmpresarial
{
    public class InicioSesion
    {
        public Cita AgendarCita(Cliente cliente, Mascota m, Consulta c, DateTime fecha)//no crea la cita ella misma entonces  se la pasa al cliente  cada clase hace lo que le corresponde (pues se la delega al cliente y aja)
        {
            return cliente.AgendarCita(m, c, fecha);
        }

        public bool IngresarEmpleado(Empleado e, string ID, string contraseña)//le pregunta al empleado si las credenciales son correctas (usa ValidarCredenciales) y devuelve true o false
        {
            return e.ValidarCredenciales(ID, contraseña);
        }
    }
}
