// "for" anidados que muestran de "L" a "N" en la misma línea 5 veces

using System;

class Ejercicio_02_02_07_02
{
    static void Main()
    {
        char letra;
        int i;
        
        for (i=0; i<5; i++)
        {
            for (letra='L'; letra <='N'; letra++)
            {
                Console.Write("{0} ", letra);
            }
        }
    }
}
