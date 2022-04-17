using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase02_Ejercicio05
{
    class TablaDeMultiplicacion
    {
        public static string Multiplicar(int numero)
        {
            StringBuilder texto = new StringBuilder();
            texto.AppendLine($"La tabla de multiplicar del numero {numero}:");
           
            for (int i = 1; i < 10; i++)
            {
                int resultado = numero * i;
                texto.AppendLine($"{numero} x {i} = {resultado}");
                
            }
            return texto.ToString();
        }
    }
}
