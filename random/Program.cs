using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace random
{
    class Program
    {
        static void Main(string[] args)
        {

            int seed1 = 123; // Valor de la semilla1
            int seed2 = 200; // Valor de la semilla2
            int columna = 30;
            int ciclo = 5;

            Random objeto1 = new Random();
            Random objeto2 = new Random(seed1);
            Random objeto3 = new Random(seed2);
            Random objeto4 = new Random();

            Console.Title = "Generando numeros con la clase Random";

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("-- objeto1 sin semilla --");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(columna, 0);
            Console.WriteLine("-- objeto2 con semilla  --");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.SetCursorPosition(columna * 2, 0);
            Console.WriteLine("-- objeto3 con semilla  --");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine();
            Console.SetCursorPosition(columna * 3, 0);
            Console.WriteLine("-- objeto4 sin semilla --");


            for (int ctr = 1; ctr <= ciclo; ctr++)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.SetCursorPosition(4, 0 + ctr);
                Console.WriteLine($"{ctr}: {objeto1.Next()}");

                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(columna + 4, 0 + ctr);
                Console.WriteLine($"{ctr}: {objeto2.Next()}");

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.SetCursorPosition(columna * 2 + 4, 0 + ctr);
                Console.WriteLine($"{ctr}: {objeto3.NextDouble()}");

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(columna * 3 + 4, 0 + ctr);
                Console.WriteLine($"{ctr}: {objeto4.Next()}");
                Console.ReadKey();
            }

            Console.WriteLine();
            Console.ResetColor();
            Console.WriteLine("Presione una tecla para terminar");
            Console.ReadKey();


        }

    }
}
