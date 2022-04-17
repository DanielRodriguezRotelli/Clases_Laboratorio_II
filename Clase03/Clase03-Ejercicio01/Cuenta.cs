using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase03_Ejercicio01
{
    public class Cuenta
    {
         string titular; //contendrá la razón social del titular de la cuenta.
         decimal cantidad; //será un número decimal que representa al monto actual de dinero en la cuenta.

        public Cuenta(string nombre, decimal saldo)
        {
            this.titular = nombre;
            this.cantidad = saldo;
        }

        public string GetRazonSoncial()
        {
            return titular;
        }

        public decimal GetSaldo()
        {
            return cantidad;
        }




        /// <summary>
        /// "mostrar" retornará una cadena de texto con todos los datos de la cuenta.
        /// </summary>
        /// <returns></returns>
        public string Mostrar()
        {
            StringBuilder ente = new StringBuilder();
            ente.AppendLine("Datos del Titular: ");
            ente.AppendLine($"Nombre: {GetRazonSoncial()}");
            ente.AppendLine($"Saldo: {GetSaldo()}");
            return ente.ToString();
        }

        /// <summary>
        /// "ingresar" recibirá un monto para acreditar a la cuenta. Si el monto ingresado es negativo, no se hará nada.
        /// </summary>
        /// <param name="monto"></param>
        /// <returns></returns>
        public void Ingresar(decimal monto)
        {
            if (monto>=0)
            {
                cantidad += monto;
            } 
        }


        /// <summary>
        /// "retirar" recibirá un monto para debitar de la cuenta. La cuenta puede quedar en negativo.
        /// </summary>
        /// <param name="monto"></param>
        /// <returns></returns>
        public void Retirar(decimal monto)
        {
            cantidad -= monto;
        }

    }
}
