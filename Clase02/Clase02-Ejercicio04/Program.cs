using System;

/*
Realizar un programa que permita realizar operaciones matemáticas simples (suma, resta, multiplicación y división).

Crear una clase llamada Calculadora que posea dos métodos estáticos (de clase):

Calcular(público): Recibirá tres parámetros, el primer operando, el segundo operando y la operación matemática. 
El método devolverá el resultado de la operación.

Validar (privado): Recibirá como parámetro el segundo operando. Este método se debe utilizar sólo cuando 
la operación elegida sea la DIVISIÓN. Este método devolverá true si el operando es distinto de cero.

Se le debe pedir al usuario que ingrese dos números y la operación que desea realizar 
(ingresando el caracter +, -, * o /).

El usuario decidirá cuándo finalizar el programa.
*/


namespace Clase02_Ejercicio04
{
    class Program
    {
        static void Main(string[] args)
        {
            double op1;
            double op2;
            string operacion = "";
            double resultado;
            string respuesta = "";
            do
            {
                Console.WriteLine("ingrese el operando 1: ");
                double.TryParse(Console.ReadLine(), out op1);

                Console.WriteLine("ingrese el operando 2: ");
                double.TryParse(Console.ReadLine(), out op2);

                Console.WriteLine("Que operacion desea realizar: + - * / ?");
                operacion = Console.ReadLine();

                resultado = Calculadora.Calcular(op1, op2, operacion);
                

                Console.WriteLine("Desea seguir operando: SI/NO ?");
                respuesta = Console.ReadLine();
            } while (respuesta != "NO");
            Console.WriteLine("USTED SALIO DEL PROGRAMA");
            
        }
    }
}
