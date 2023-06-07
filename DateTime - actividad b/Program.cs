using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_B
{
    internal class Program
    {
        static void Main()
        {
            DateTime inicio = DateTime.Now; // Obtener el momento de inicio

            for (int i = 0; i < 100; i++) // código que se mide
            {
                Console.Write("{0} ", i + 1);
            }
            Console.WriteLine();

            DateTime fin = DateTime.Now; // fin del contador de tiempo

            TimeSpan tiempoTranscurrido = fin - inicio;
            double tiempoEnMilisegundos = tiempoTranscurrido.TotalMilliseconds;

            Console.WriteLine("Tiempo de ejecución: " + tiempoEnMilisegundos + " milisegundos");
            Console.WriteLine("(el tiempo depende de la velocidad del ordenador)");
            Console.ReadLine();
        }
    }
}

