using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Crear una aplicación de consola y una biblioteca de clases que contenga la clase Persona.

Deberá tener los atributos:
-nombre
-fechaDeNacimiento
-dni
Deberá tener un constructor que inicialice todos los atributos.

Construir los siguientes métodos para la clase:

-Setter y getter para cada uno de los atributos.
-CalcularEdad será privado y retornará la edad de la persona calculándola a partir de la fecha de nacimiento.
-Mostrar retornará una cadena de texto con todos los datos de la persona, incluyendo la edad actual.
-EsMayorDeEdad si es mayor de edad devuelve el valor “Es mayor de edad", sino devuelve “es menor”.
1-Instanciar 3 objetos de tipo Persona en el método Main.
2-Mostrar quiénes son mayores de edad y quiénes no.
*/




namespace Clase03_Ejercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Persona uno = new Persona("Andres", "12/03/2013","36897415");
            Persona dos = new Persona("Aye", "08/04/1992", "3672289987");
            Persona tres = new Persona("Daniel", "31/03/1979", "27202150");
            Console.WriteLine(uno.Mostrar());
            Console.WriteLine(dos.Mostrar());
            Console.WriteLine(tres.Mostrar());

            Console.ReadKey();
        }
    }
}
