// Muestra un triángulo de asteriscos con la base introducida por el usuario
using System;

class Ejercicio_02_02_06_04
{
    static void Main()
    {
        int ancho, i, j;
        
        Console.Write("Introduce el tamaño de la base: ");
        ancho = Convert.ToInt32(Console.ReadLine());        
        
        for (i = 0; i < ancho; i++)
        {
            for (j = ancho - i; j <= ancho; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}
