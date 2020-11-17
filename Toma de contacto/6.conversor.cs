// Hugo Martínez
// Conversor millas a metros usando 3 variables y Write

using System;

class conversor
{
    static void Main()
    {
        int millas, metros, millasPorMetro;
        millasPorMetro = 1609;
        
        Console.Write("Introduce la cantidad de millas: ");
        millas = Convert.ToInt32(Console.ReadLine());
        
        metros = millas * millasPorMetro;
        
        Console.Write(millas);
        Console.Write(" millas son ");
        Console.Write(metros);
        Console.Write(" metros");
        
        // Versión con WriteLine:
        // Console.WriteLine("{0} millas son {1} metros", millas, metros);
    }
}
