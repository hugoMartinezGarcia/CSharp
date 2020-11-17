// Indica qué números entre 10 y 20 son divisibles entre 5, 6 y 7.

using System;

class Ejercicio_02_02_05_03
{
    static void Main()
    {
        int i, j;
        
        for (i = 5; i <=7 ; i++)
        {
            for (j = 10; j <= 20; j++)
                {
                    if (j % i == 0)
                    {
                        Console.WriteLine("{0} es divisible entre {1}", j, i);
                    }
                }
        }
    }
}
