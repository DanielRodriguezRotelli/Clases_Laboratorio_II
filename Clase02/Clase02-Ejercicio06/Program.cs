using System;
using System.Text;

/*
Realizar una clase llamada CalculadoraDeArea que posea tres métodos de 
clase (estáticos) que realicen el cálculo del área que corresponda:

public double CalcularAreaCuadrado(double longitudLado) { }

public double CalcularAreaTriangulo(double base, double altura) { }

public double CalcularAreaCirculo(double radio) { }

El ingreso de los datos como la visualización se deberán realizar desde el método Main().
*/

namespace Clase02_Ejercicio06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Que area desea calcular: cuadrado, triangulo o circulo ?");
            string respuesta = Console.ReadLine();

            switch (respuesta)
            {
                case "cuadrado":
                    double longitud;
                    Console.WriteLine("Ingrese la longitud del lado: ");
                    if (!double.TryParse(Console.ReadLine(), out longitud))
                    { 
                        Console.WriteLine("Error. El valor no es valido.");
                    }
                    else
                    {
                        Console.WriteLine($"El area del cuadrado es de : {CalculadoraDeArea.CalcularAreaCuadrado(longitud)}");
                    }
                    break;

                case "triangulo":
                    double baase;
                    double altura;
                    Console.WriteLine("Ingrese la longitud de la base: ");
                    if (double.TryParse(Console.ReadLine(), out baase))
                    {
                        Console.WriteLine("Ingrese la longitud de la altura: ");
                        if (double.TryParse(Console.ReadLine(), out altura))
                        {
                            Console.WriteLine($"El area del triangulo es de : {CalculadoraDeArea.CalcularAreaTriangulo(baase, altura)}");
                        }
                        else
                        {
                            Console.WriteLine("Error. El valor no es valido.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Error. El valor no es valido.");
                    }
                    break;

                case "circulo":
                    double radio;
                    Console.WriteLine("Ingrese la longitud del lado: ");
                    if (double.TryParse(Console.ReadLine(), out radio))
                    {
                        Console.WriteLine($"El area del circulo es de : {CalculadoraDeArea.CalcularAreaCirculo(radio)}");
                    }
                    else
                    {
                        Console.WriteLine("Error. El valor no es valido.");
                    }
                    break;
                default:
                    Console.WriteLine("Esa palabra no es correcta");
                    break;
            }
            Console.Read();
        }
        
    }
}
