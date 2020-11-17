// Escribe los números de 1 al 10 usando do..while

using System;

class Ejercicio_02_02_02_02
{
    static void Main()
    {
        int num = 1;
        
        do
        {
            Console.WriteLine(num);
            num = num + 1;
        }
        while (num <= 10);
    
    }
}

