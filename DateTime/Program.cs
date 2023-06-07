using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese una fecha y hora en uno de los siguientes formatos:");
        Console.WriteLine("1. dd/MM/yyyy HH:mm:ss");
        Console.WriteLine("2. MM/dd/yyyy HH:mm:ss");
        Console.WriteLine("3. yyyy/MM/dd HH:mm:ss");
        string input = Console.ReadLine();

        DateTime dateTime;

        if (DateTime.TryParseExact(input, new string[] { "dd/MM/yyyy HH:mm:ss", "MM/dd/yyyy HH:mm:ss", "yyyy/MM/dd HH:mm:ss" },
                                   null, System.Globalization.DateTimeStyles.None, out dateTime))
        {
            Console.WriteLine("\nFecha y hora en formatos diferentes:");
            Console.WriteLine("1. dd/MM/yyyy HH:mm:ss: " + dateTime.ToString("dd/MM/yyyy HH:mm:ss"));
            Console.WriteLine("2. MM/dd/yyyy HH:mm:ss: " + dateTime.ToString("MM/dd/yyyy HH:mm:ss"));
            Console.WriteLine("3. yyyy/MM/dd HH:mm:ss: " + dateTime.ToString("yyyy/MM/dd HH:mm:ss"));
            Console.WriteLine("4. dd/MM/yyyy: " + dateTime.ToString("dd/MM/yyyy"));
            Console.WriteLine("5. MM/dd/yyyy: " + dateTime.ToString("MM/dd/yyyy"));
        }
        else
        {
            Console.WriteLine("El formato de fecha y hora ingresado no es válido.");
        }

        Console.ReadLine();

    }

}

