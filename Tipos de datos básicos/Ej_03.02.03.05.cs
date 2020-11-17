// Muestra los primeros 20 valores de la función y = x^2 - 1

using System;

class Ejercicio_03_02_03_05
{
    static void Main()
    {
        float y; 
        
        for (int x = 0; x < 20; x++)
        {
            y = x*x -1;
            Console.WriteLine("Para x = {0}, y = {1}", x, y);
        }
    }
}
