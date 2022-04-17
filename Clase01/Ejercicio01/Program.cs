using System;

/*CLASE 01 - EJERCICIO 01
Ingresar 5 números por consola, guardándolos en una variable escalar. 
Luego calcular y mostrar: el valor máximo, el valor mínimo y el promedio.*/

namespace Ejercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalNumeros = 5;
            int numMax = 0;
            int numMin = 0;
            int auxParseado;
            string numeroIngresado;
            float promedio = 0;

            for (int i = 0; i < totalNumeros; i++)
            {
                Console.WriteLine("Ingrese un numero por favor : ");
                numeroIngresado = Console.ReadLine();

                if (int.TryParse(numeroIngresado, out auxParseado))
                {

                    if (auxParseado > numMax)
                    {
                        numMax = auxParseado;
                    }
                    if (auxParseado < numMin)
                    {
                        numMin = auxParseado;
                    }
                    Console.WriteLine("Usted ingreso: {0}", auxParseado);
                    promedio = promedio + auxParseado;
                }
                else
                {
                    Console.WriteLine("El valor ingresado es incorrecto.");
                    i--;
                }

            }

            promedio = promedio / totalNumeros;
            Console.WriteLine("El maximo es: {0}. El minimo es: {1}. El promedio es: {2}", numMax,numMin,promedio);
            
            Console.Read();

        }
     
    }
}
