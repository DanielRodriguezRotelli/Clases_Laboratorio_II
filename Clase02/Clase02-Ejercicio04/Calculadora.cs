using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase02_Ejercicio04
{
    class Calculadora
    {
        public static double Calcular(double num1, double num2, string operacion)
        {
            double resultado=0;
            switch (operacion)
            {
                case "+":
                    resultado= num1 + num2;
                    Console.WriteLine("La suma de {0} + {1} es: {2}",num1,num2,resultado);
                    break;

                case "-":
                    resultado= num1 - num2;
                    Console.WriteLine("La resta de {0} - {1} es: {2}", num1, num2, resultado);
                    break;

                case "*":
                    resultado= num1 * num2;
                    Console.WriteLine("La multiplicacion de {0} * {1} es: {2}", num1, num2, resultado);
                    break;

                case "/":
                    if (Validar(num2) == true)
                    {
                        resultado= num1 / num2;
                        Console.WriteLine("La division de {0} / {1} es: {2}", num1, num2, resultado);
                    }
                    else
                    {
                         Console.WriteLine("No se puede dividir por 0");
                    }
                    break;
            }
            return resultado;

        }

        private static bool Validar(double num2)
        {
            if (num2==0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

    }
}
