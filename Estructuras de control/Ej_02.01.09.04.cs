// Pide un número del 1 al 10 y escribe le nombre de ese número. Usando "if"

using System;

class Ej_09_01_09_04
{
    static void Main()
    {
        int num;
        
        Console.WriteLine("Introduce un número del 1 al 10:");
        num =  Convert.ToInt32(Console.ReadLine());
        
        if (num == 1)
        {
             Console.WriteLine("Uno.");
        }
        else if (num == 2)
        {
            Console.WriteLine("Dos.");
        }
        else if (num == 3)
        {
            Console.WriteLine("Tres.");
        }
        else if (num == 4)
        {
            Console.WriteLine("Cuatro.");
        }
        else if (num == 5)
        {
            Console.WriteLine("Cinco");
        }
        else if (num == 6)
        {
            Console.WriteLine("Seis");
        }
        else if (num == 7)
        {
            Console.WriteLine("Siete.");
        }
        else if (num == 8)
        {
            Console.WriteLine("Ocho.");
        }
        else if (num == 9)
        {
            Console.WriteLine("Nueve.");
        }
        else
        {
            Console.WriteLine("Número desconocido.");
        }
    }
}
