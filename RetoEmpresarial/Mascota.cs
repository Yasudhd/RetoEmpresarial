using System;
using System.Collections.Generic;
using System.Text;

namespace RetoEmpresarial
{
    public class Mascota
    {
        private string nombre;
        private string especie;
        private string raza;
        private int edad;
        private double peso;
        private string estadoSalud;
        private HistoriaClinica historia = new HistoriaClinica();
        public Mascota(string nombre, string especie, string raza, int edad, double peso, string estadoSalud)
        {
            this.nombre = nombre;
           this.especie = especie;
            this.raza = raza;
            this.edad = edad;
           this.peso = peso;
            this.estadoSalud = estadoSalud;
        }
        public HistoriaClinica ObtenerHistoria()  //devuelve su historia clínica 
        {
           return historia;
        }
        public void CambiarEstadoSalud(string nuevoEstado) { estadoSalud = nuevoEstado; }//actualiza su estado de salud
        public void ActualizarPeso(double nuevoPeso) { peso = nuevoPeso; }//actualiza su peso
        public override string ToString()//devuelve un texto con los datos de la mascota pues es  lo que se imprime cuando hacemos un Console.WriteLine(m)
        {
            return $"{nombre} ({especie}, {raza}), {edad} años, {peso} kg, estado: {estadoSalud}";
        }
    }
}
