// Muestra un triángulo de asteriscos descendente on la base introducida por el usuario
using System;

class Ejercicio_02_02_06_05
{
    static void Main()
    {
        int ancho, i, j;
        
        Console.Write("Introduce el tamaño de la base: ");
        ancho = Convert.ToInt32(Console.ReadLine());        
        
        for (i = 1; i <= ancho; i++)
        {
            for (j = i; j <= ancho; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}
