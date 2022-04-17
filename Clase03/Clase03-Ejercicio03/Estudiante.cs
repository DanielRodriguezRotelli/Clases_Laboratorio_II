using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase03_Ejercicio03
{
    class Estudiante
    {
        //atributos
        private string apellido;
        private string nombre;
        private string legajo;
        private int notaPrimerParcial;
        private int notaSegundoParcial;
        private static Random random;

        //constructor

        public static Random(Random random)
        {
            this.
        }
        public Estudiante(string apellido, string nombre, string legajo)
        {
            this.apellido = apellido;
            this.nombre = nombre;
            this.legajo = legajo;
        }

        public void SetNotaPrimerParcial(int nota)
        {
            if (nota < 1 && nota > 10)
            {
                nota = 0;
            }
            this.notaPrimerParcial = nota;
        }

        public void SetNotaSegundoParcial(int nota)
        {
            if (nota < 1 && nota > 10)
            {
                nota = 0;
            }
            this.notaSegundoParcial = nota;
        }

        private float CalcularPromedio()
        {
            float promedio = (this.notaPrimerParcial + this.notaSegundoParcial) / 2;
            return promedio;
        }

        public int CalcularNotaFinal()
        {
            if (this.notaPrimerParcial>=4 && this.notaSegundoParcial>=4)
            {
                return
            }
            else
            {

            }

        }



        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {this.nombre} Apellido: {this.apellido} Legajo: {this.legajo}");
            sb.AppendLine($"Nota Primer Parcial: {this.notaPrimerParcial}. Nota Primer Parcial: {this.notaSegundoParcial}");
            sb.AppendLine($"Promedio: {CalcularPromedio()}");




        }
    }
}
