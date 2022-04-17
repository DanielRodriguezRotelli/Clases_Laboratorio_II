using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPractica
{
    public class Gato
    {
        private string nombre;
        private double peso;
        private DateTime fechaDeNacimiento;

        public Gato(string nombre, double peso, DateTime fechaNacimiento)
        {
            this.nombre = nombre;
            this.fechaDeNacimiento = fechaNacimiento;
        }

        public Gato()
        {
        }

        public Gato(string nombre, DateTime fechaNacimiento)
        {
            this.nombre = nombre;
            this.fechaDeNacimiento = fechaNacimiento;
        }

        public void AsignarPeso(double peso)
        {
            this.peso = peso;
        }

        public double ObtenerPeso()
        {
            return peso;
        }

        public string ObtenerDatos()
        {
            StringBuilder gt = new StringBuilder();
            gt.AppendLine("Datos del Gato: ");
            gt.AppendFormat("Nombre del michi : {0} ", nombre);
            gt.AppendLine("");
            gt.Append("Fecha de nacimiento: ");
            gt.AppendLine(fechaDeNacimiento.ToString("dd/MM/yyyy"));
            gt.AppendLine($"Peso: {peso}");
            
            return gt.ToString();
        }
        
    }
}
