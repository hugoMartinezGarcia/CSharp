// Dibuja un cuadrado con el lado introducido por el usuario

using System;

class Ejercicio_02_02_06_03
{
    static void Main()
    {
        int lado, i, j;
        
        Console.Write("Introduce el tamaño del lado: ");
        lado = Convert.ToInt32(Console.ReadLine());        
        
        for (i = 1; i <= lado; i++)
        {
            for (j = 1; j <= lado; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}
