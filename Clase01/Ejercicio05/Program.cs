using System;

/*CLASE 01 - EJERCICIO 05
Un centro numérico es un número que separa una lista de números enteros (comenzando en 1) 
en dos grupos de números, cuyas sumas son iguales.
El primer centro numérico es el 6, el cual separa la lista (1 a 8) en los grupos: (1; 2; 3; 4; 5) y (7; 8) 
cuyas sumas son ambas iguales a 15. El segundo centro numérico es el 35, el cual separa la lista (1 a 49) 
en los grupos: (1 a 34) y (36 a 49) cuyas sumas son ambas iguales a 595.
Se pide elaborar una aplicación que calcule los centros numéricos entre 1 y el número que el usuario 
ingrese por consola.
 */




namespace Ejercicio05
{
    class Program
    {
        static void Main(string[] args)
        {

            int numero;
            Console.WriteLine("Ingrese un numero: ");

            while (int.TryParse(Console.ReadLine(), out numero))
            {
                //recorro desde el 1 hasta el numero ingresado por el usuario.
                for (int centro = 1; centro < numero; centro++)
                {
                    //sumo los numeros inferiores al centro
                    int sumaAntes = 0;
                    for (int i = 0; i < centro; i++)
                    {
                        sumaAntes += i;
                    }
                    //sumo los numeros superiores al centro.
                    int sumaDespues = 0;
                    for (int j = centro + 1; j <= sumaAntes; j++)
                    {
                        if ((sumaAntes == sumaDespues) || (sumaDespues>sumaAntes))
                        {
                            break;
                        }
                        sumaDespues += j;

                        //mostrar en pantalla.
                        if (sumaAntes == sumaDespues)
                        {
                            Console.WriteLine("{0} Es un centro numerico.", centro);
                        }
                    }
                }
            }
            Console.WriteLine("NO ES UN NUMERO VALIDO.");
            Console.Read();
        }
    }
}
