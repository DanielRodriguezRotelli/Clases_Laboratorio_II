using System;

/*
Realizar un programa que sume números enteros hasta que el usuario lo determine 
por medio de un mensaje "¿Desea continuar? (S/N)".

Crear la clase Validador y el método estático ValidarRespuesta, que validará el ingreso de respuestas.

El método devolverá un valor de tipo booleano, TRUE si se ingresó una 'S' y FALSE 
si se ingresó cualquier otro valor.
*/


namespace Clase02_Ejercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int resultado;
            int numero1 = 0;
            int numero2 = 0;
            string respuesta="";
            int i = 0;

            Console.WriteLine("Hello World!");
            do
            {
                Console.WriteLine("Ingrese un operador:");
                if(!int.TryParse(Console.ReadLine(), out numero1))
                {
                    Console.WriteLine("Error. Ese no es numero.");
                }
                Console.WriteLine("Ingrese un segundo operador:");
                if (!int.TryParse(Console.ReadLine(), out numero2))
                {
                    Console.WriteLine("Error. Ese no es numero.");
                }

                resultado = numero1 + numero2;
                Console.WriteLine("{0} + {1} = {2}",numero1,numero2,resultado);
                Console.WriteLine("Desea continuar?: S/N");
                respuesta = Console.ReadLine();
                
            } while (Validador.ValidarRespuesta(respuesta) != true);


            
        }
    }
}
