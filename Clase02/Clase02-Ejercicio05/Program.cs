using System;
using System.Text;



/*
Crear una aplicación de consola que permita al usuario ingresar un número entero.
Desarrollar un método estático que reciba un número y devuelva la tabla de multiplicación 
de ese número en formato string.
Se deberá utilizar la clase StringBuilder combinada con strings interpolados para armar el resultado.
Mostrar en la consola el resultado.
Por ejemplo, si se ingresa el número 2 la salida deberá ser:

Tabla de multiplicar del número 2:
2 x 1 = 2
2 x 2 = 4
2 x 3 = 6
2 x 4 = 8
2 x 5 = 10
2 x 6 = 12
2 x 7 = 14
2 x 8 = 16
2 x 9 = 18
*/


namespace Clase02_Ejercicio05
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroIngresado;
            do
            {
                Console.WriteLine("Ingrese un numero entero por favor: ");
            } while (!int.TryParse(Console.ReadLine(), out numeroIngresado));
            
            Console.WriteLine(TablaDeMultiplicacion.Multiplicar(numeroIngresado));
            Console.Read();

        }
    }
}
