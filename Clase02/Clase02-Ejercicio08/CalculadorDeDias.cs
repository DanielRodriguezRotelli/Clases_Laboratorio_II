using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase02_Ejercicio08
{
    class CalculadorDeDias
    {
        public static string CalcularDiasVivos(string fecha)
        {
            DateTime fechaNacimiento = new DateTime();
            if (DateTime.TryParse(fecha, out fechaNacimiento))
            {
                //Console.WriteLine(fechaNacimiento.ToString("dd-mm-yy"));
                int cantidadDias = DateTime.Today.Subtract(fechaNacimiento).Days;
                string dias = Convert.ToString(cantidadDias);
                return dias;
                    
            }
            else
            {
                string mensaje = "Hay un error en la fecha ingresada";
                return mensaje;
            }
        }
    }
}
