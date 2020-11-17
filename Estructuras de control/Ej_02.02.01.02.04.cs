// Muestra tantos asteriscos como muestra el usuario

using System;

class Ejercicio_02_02_01_02_04
{
    static void Main()
    {
        int n, numAsteriscos = 0;
        
        Console.Write("¿Cuántos asteriscos quieres ver?: ");
        n = Convert.ToInt32(Console.ReadLine());
        
        while (numAsteriscos < n)
        {
            Console.Write("*");                
            numAsteriscos = numAsteriscos + 1;
        }
    }
}
