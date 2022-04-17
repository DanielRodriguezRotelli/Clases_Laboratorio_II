using System;

/*
Crear una aplicación de consola que pida al usuario ingresar la base y la altura de un triángulo en centímetros.

El programa deberá calcular la longitud de la hipotenusa aplicando el teorema de pitágoras y

Usar los métodos Pow y Sqrt de la clase Math para realizar los cálculos.

Mostrar el resultado en la consola.
*/


namespace Clase02_Ejercicio07
{
    class Program
    {
        static void Main(string[] args)
        {
            double baase;
            double altura;
            Console.WriteLine("Igrese la base del triangulo");
            if(double.TryParse(Console.ReadLine(), out baase))
            {
                Console.WriteLine("Igrese la altura del triangulo");
                if (double.TryParse(Console.ReadLine(), out altura))
                {
                    Console.WriteLine($"La longitud de la hipotenusa es " +
                        $"de: {TeoremaPitagoras.CalcularHipotenusa(baase, altura)}");
                }
                else
                {
                    Console.WriteLine("Error. El valor ingresado no es correcto.");
                }
            }
            else
            {
                Console.WriteLine("Error. El valor ingresado no es correcto.");
            }
            Console.ReadKey();

        }
    }
}
