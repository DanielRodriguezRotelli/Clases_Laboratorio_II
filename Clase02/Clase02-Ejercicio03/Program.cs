using System;

/*
Desarollar una clase llamada Conversor que posea dos métodos de clase (estáticos):

El método ConvertirDecimalABinario que convierte un número entero del sistema decimal al sistema binario.

public string ConvertirDecimalABinario(int numeroEntero) { }

El método ConvertirBinarioADecimal que convierte un número entero del sistema binario al sistema decimal.

public int ConvertirBinarioADecimal(int numeroEntero) { }
*/

namespace Clase02_Ejercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escribe un numero decimal");
            int numero = Convert.ToInt32(Console.ReadLine());

            int binario = Conversor.ConvertirDecimalABinario(numero);
            Console.WriteLine("El numero decimal " + numero + " en binario es " + binario);

            int decimalB = Conversor.ConvertirBinariADecimal(binario);
            Console.WriteLine("El numero binario " + binario + " en decimal es " + decimalB);

            Console.ReadLine();
        }
    }
}
