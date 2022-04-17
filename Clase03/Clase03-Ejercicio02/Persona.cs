using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase03_Ejercicio02
{
    class Persona
    {
        //Atributos
        string nombre;
        DateTime fechaDeNacimiento;
        string dni;

        //Constructor
        public Persona(string nombre, string fechaNacimiento, string nroDocumento)
        {
            this.nombre = nombre;
            this.fechaDeNacimiento = Convert.ToDateTime(fechaNacimiento);
            this.dni = nroDocumento;
           
        }

        //GETTERS
        public string GetNombre()
        {
            return nombre;
        }

        public DateTime GetFechaDeNacimiento()
        {
            return fechaDeNacimiento;
        }

        public string GetDni()
        {
            return dni;
        }
        /*
        //SETTERS
        public void SetNombre(string nombre)
        {
            if (string.IsNullOrWhiteSpace(nombre))
            {
                nombre = "SIN NOMBRE";
            }
            this.nombre = nombre.Trim();
        }
        
        public void SetFechaDeNacimiento(string fecha)
        {
            DateTime fechaNacimiento = new DateTime();
            if (DateTime.TryParse(fecha, out fechaNacimiento))
            {
                this.fechaDeNacimiento = new DateTime(fecha);
            }
        }

        public void SetDni(string documento)
        {
            if (string.IsNullOrWhiteSpace(documento))
            {
                documento = "SIN DNI";
            }
            this.dni = documento.Trim();
        }*/

        
        private int CalcularEdad()
        {
            int cantidadDias = DateTime.Today.Subtract(this.fechaDeNacimiento).Days;
            return cantidadDias/365;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {this.nombre}");
            sb.AppendLine($"Fecha de Nacimiento: {this.fechaDeNacimiento}");
            sb.AppendLine($"Edad: {CalcularEdad()}");
            sb.AppendLine($"DNI: {this.dni}");
            sb.AppendLine($"{EsMayor()}");
            return sb.ToString();
        }
        
        public string EsMayor()
        {
            int edad = CalcularEdad();
            if (edad>=18)
            {
                return "ES MAYOR DE EDAD";
            }
            else
            {
                return "ES MENOR";
            }
        }


    }
}
