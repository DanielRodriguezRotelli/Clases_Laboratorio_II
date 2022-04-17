using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase02_Ejercicio06
{
    class CalculadoraDeArea
    {
        public static double CalcularAreaCuadrado(double longitudLado)
        {
            double area = Math.Pow(longitudLado, 2);
            return area;           
        }

        public static double CalcularAreaTriangulo(double baase, double altura) 
        {
            double area = (baase * altura) / 2;
            return area;
        }

        public static double CalcularAreaCirculo(double radio) 
        {
            double area = Math.PI * Math.Pow(radio, 2);
            return area;
        }

    }
}
