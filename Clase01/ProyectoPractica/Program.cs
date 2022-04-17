using System;

namespace ProyectoPractica
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hola mundo");

            Gato michi = new Gato("Rodolfo", new DateTime(2014, 09, 13));
            Gato monguito = new Gato("Guilmour", new DateTime(1,1,1));
            
            monguito.AsignarPeso(14);
            michi.AsignarPeso(13);
            Console.WriteLine(michi.ObtenerDatos()); 
            Console.WriteLine(monguito.ObtenerDatos()); 




            Console.Read();


        }
    }
}
