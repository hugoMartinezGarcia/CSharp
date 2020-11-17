// Muestra 4 veces los números dle 1 al 5 en una línea, usando "while"

using System;

class Ejercicio_02_02_05_02
{
    static void Main()
    {
        int n1 = 1, n2;
        
        while (n1 <= 4)
        {
            n2 = 1;
            while (n2 <= 5)
            {
                Console.Write(n2);
                n2++;
            }
            n1++;
        }
    }
}
