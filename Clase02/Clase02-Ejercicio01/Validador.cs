using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase02_Ejercicio01
{
    class Validador
    {
        const int minimo = -100;
        const int maximo = 100;

        public static bool Validar(int valor, int min, int max)
        {
            if (valor<min || valor>max)
            {
                Console.WriteLine("El valor esta por fuera del rango permitido.");
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
