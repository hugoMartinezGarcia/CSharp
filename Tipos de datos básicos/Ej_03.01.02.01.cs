// Pide al usuario su edad y lo guarda en un byte.

using System;

class Ejercicio_03_01_02_01
{
    static void Main()
    {
        byte edad;
        
        Console.WriteLine("Introduce tu edad:");
        edad = Convert.ToByte(Console.ReadLine());
        
        Console.WriteLine("No aparentas {0} años.", edad);
    }
}
