// Pide el ancho y alto y dibuja un rectánculo de asteriscos.

using System;

class Ejercicio_02_02_08_02
{
    static void Main()
    {
        int ancho, alto;
        
        Console.Write("Introduce la anchura: ");
        ancho = Convert.ToInt32(Console.ReadLine());
        Console.Write("Introduce la altura: ");
        alto = Convert.ToInt32(Console.ReadLine());
        
        for (int filaActual=1; filaActual<=alto; filaActual++)
        {
            for (int columnaActual=1; columnaActual<=ancho; columnaActual++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}
