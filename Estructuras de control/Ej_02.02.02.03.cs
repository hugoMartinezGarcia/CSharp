// Escribe los números pares desde el 26 hasta el 10.

using System;

class Ejercicio_02_02_02_03
{
    static void Main()
    {
        int num = 26;
        
        do
        {
            Console.WriteLine(num);
            num = num - 2;
        }
        while (num >= 10);
    
    }
}

