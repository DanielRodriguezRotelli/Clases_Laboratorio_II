using System;

/*CLASE 01 - EJERCICIO 03
Mostrar por pantalla todos los números primos que haya hasta el número que ingrese el usuario por consola.
Validar que el dato ingresado por el usuario sea un número.
Volver a pedir el dato hasta que sea válido o el usuario ingrese "salir".
Si ingresa "salir", cerrar la consola.
Al finalizar, preguntar al usuario si desea volver a operar. Si la respuesta es afirmativa, iterar. 
De lo contrario, cerrar la consola.
 */


namespace Ejercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            string respuesta = "";
            string numeroIngresado;
            int auxNumero;
            //int numero = 2;
            int divisor = 0;
           //int j;
            
            do
            {
                Console.WriteLine("Ingrese un numero por favor");
                numeroIngresado = Console.ReadLine();
                if (int.TryParse(numeroIngresado, out auxNumero))
                {
                    for (int i = 1; i <= auxNumero; i++)
                    {
                        for (int j = 1; j <=i; j++)
                        {
                            if (i%j ==0)
                            {
                                divisor++;
                            }
                        }
                        //Console.WriteLine(i);
                        if (divisor == 2)
                        {
                            Console.WriteLine("{0} es numero primo", i);
                        }
                        divisor = 0;
                    }
                }
                else
                {
                    Console.WriteLine("Error. Ingrese un numero valido.");
                    numeroIngresado = Console.ReadLine();
                    if (int.TryParse(numeroIngresado, out auxNumero))
                    {
                        for (int i = 1; i <= auxNumero; i++)
                        {
                            for (int j = 1; j <= i; j++)
                            {
                                if (i % j == 0)
                                {
                                    divisor++;
                                }
                            }
                            //Console.WriteLine(i);
                            if (divisor == 2)
                            {
                                Console.WriteLine("{0} es numero primo", i);
                            }
                            divisor = 0;
                        }
                    }
                }
                Console.WriteLine("Si desea seguir iterando, ingrese 'S'. De lo contrario, escriba 'salir'.");
                respuesta = Console.ReadLine();
            } while (respuesta != "salir");
        
            Console.WriteLine("Usted salio del programa");
            Console.Read();
        }
    }
}



