// Pide al usuario el ancho y el alto y dibuja en rectánculo de ese tamaño

using System;

class Ejercicio_02_02_06_02
{
    static void Main()
    {
        int ancho, alto, i, j;
        
        Console.Write("Introduce la altura: ");
        alto = Convert.ToInt32(Console.ReadLine());        
        Console.Write("Introduce la anchura: ");
        ancho = Convert.ToInt32(Console.ReadLine());
        
        for (i = 1; i <= alto; i++)
        {
            for (j = 1; j <= ancho; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}
