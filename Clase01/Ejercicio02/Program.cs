using System;

/*CLASE 01 - EJERCICIO 02
 Ingresar un número y mostrar el cuadrado y el cubo del mismo. Se debe validar que el 
número sea mayor que cero, caso contrario, mostrar el mensaje: "ERROR. ¡Reingresar número!".
 */

namespace Ejercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            double numIngresado,resultadoCuadrado,resultadoCubo;
            double resultado;

            //Console.WriteLine("Ingrese un numero por favor: ");
            //numIngresado = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine(numIngresado);
            //Console.Read();
            do
            {
                Console.WriteLine("Ingrese un numero por favor: ");
                numIngresado = Convert.ToDouble(Console.ReadLine());
                if (numIngresado <= 0)
                {
                    Console.WriteLine("El numero ingresado es incorrecto");
                }
                else
                {
                    resultado = Math.Pow(3, 2);
                    resultadoCuadrado = Math.Pow(numIngresado, 2);
                    resultadoCubo = Math.Pow(numIngresado, 3);
                    Console.WriteLine(resultado);
                    Console.WriteLine("El numero ingresado es: " + numIngresado);
                    Console.WriteLine("Su cuadrado es: " + resultadoCuadrado);
                    Console.WriteLine("Su cubo es: " + resultadoCubo);
                }
            } while (numIngresado<=1);
            
            Console.Read();
        }
    }
}
