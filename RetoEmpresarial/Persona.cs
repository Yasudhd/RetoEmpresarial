using System;
using System.Collections.Generic;
using System.Text;

namespace RetoEmpresarial
{
    public abstract class Persona
    {
        protected string nombre;
        protected string documento;
        protected long telefono;
        protected string correo;
        public Persona(string nombre, string documento, long telefono, string correo) 
        {
            this.nombre = nombre;
            this.documento = documento;
            this.telefono = telefono;
            this.correo = correo;
        }
    }
}
