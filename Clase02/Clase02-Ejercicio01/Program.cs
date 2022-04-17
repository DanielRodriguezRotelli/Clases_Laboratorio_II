using System;

/*
Realizar una clase llamada Validador que posea un método estático llamado Validar con la siguiente firma:

bool Validar(int valor, int min, int max)

valor: dato a validar.
min: mínimo valor incluido.
max: máximo valor incluido.
Pedir al usuario que ingrese 10 números enteros. Validar con el método desarrollado 
anteriormente que estén dentro del rango -100 y 100.

Terminado el ingreso mostrar el valor mínimo ingresado, valor máximo ingresado y el promedio.
*/

namespace Clase02_Ejercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            int valoringresado;
            double valortotal=0;
            double minimo = 0;
            double maximo = 0;
            double promedio=0;
            int i = 0;

            Console.WriteLine("Hello World!");
            for (i = 0; i < 10; i++)
            { 
                Console.WriteLine("Ingrese un numero por favor: ");
                if (int.TryParse(Console.ReadLine(), out valoringresado))
                {
                    if (Validador.Validar(valoringresado,-100,100) == true)
                    {
                        if (i==0 || valoringresado<minimo)
                        {
                            minimo = valoringresado;
                        }
                        if (i == 0 || valoringresado > maximo)
                        {
                            maximo = valoringresado;
                        }
                        valortotal +=  valoringresado;
                    }
                    else
                    {
                        i--;
                    }
                    

                }
                else
                {
                    Console.WriteLine("Error, Reingrese un numero por favor. ");
                    i--;
                }
            }
            promedio =  valortotal / i;
            Console.WriteLine("El total de valor es: {0}", valortotal);
            Console.WriteLine("El cantidad total de i es: {0}", i);
            Console.WriteLine("El promedio es: {0}", promedio);
            Console.WriteLine("El minimo es: {0}", minimo);
            Console.WriteLine("El maximo es: {0}", maximo);
        }
    }
}
