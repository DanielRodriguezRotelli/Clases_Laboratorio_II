using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase02_Ejercicio07
{
    class TeoremaPitagoras
    {
        public static double CalcularHipotenusa(double num1, double num2)
        {
            double resultado = Math.Sqrt(Math.Pow(num1,2) + Math.Pow(num2,2));
            return resultado;
        }
    }
}
