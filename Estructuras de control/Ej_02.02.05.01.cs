// Muestra 4 veces los números dle 1 al 5 en una línea, usando "for"

using System;

class Ejercicio_02_02_05_01
{
    static void Main()
    {
        int n1, n2;
        
        for (n1 = 1; n1 <= 4; n1++)
            for (n2 = 1; n2 <= 5; n2++)
                Console.Write(n2);
    }
}
