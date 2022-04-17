using System;

/*CLASE 01 - EJERCICIO 04
Un número perfecto es un entero positivo, que es igual a la suma de todos los 
enteros positivos (excluido el mismo) que son divisores del número.
El primer número perfecto es 6, ya que los divisores de 6 son 1, 2 y 3; y 1 + 2 + 3 = 6.
Escribir una aplicación que encuentre los 4 primeros números perfectos.
 */


namespace Ejercicio04
{
    class Program
    {
        static bool esPerfecto (int n)
        {
            int suma = 0;
            int i = 1;

            while (i < n)
            {
                if (n%i == 0)
                {
                    suma+=i;
                    if (suma>n)
                    {
                        return false;
                    }
                }
                i++;
            }
            return (suma == n);
        }
        static void Main(string[] args)
        {
            int numero = 0;

            while (numero < 10000)
            {
                if (esPerfecto(numero))
                {
                    Console.WriteLine("{0} es numero perfecto",numero);
                }
                numero++;
            }
            Console.WriteLine("Hello World!");
            Console.Read();
        }
    }
}
