using System;
using System.Collections.Generic;
using System.Text;

namespace RetoEmpresarial
{
    public abstract class Empleado : Persona
    {
        protected string ID;
        protected string Contrasena;

        public Empleado(string nombre, string documento, long telefono, string correo,string ID, string contrasena) : base(nombre, documento, telefono, correo)
        {
            this.ID = ID;
            this.Contrasena = contrasena;
        }
        public bool ValidarCredenciales(string id, string clave)//esto revisa si el ID y la contraseña coinciden con los del empleado entonces devuelve true si coinciden y false si no 
        {
            return ID == id && Contrasena == clave;
        }
    }
}
