// Muestra en pantalla los números pares del 26 al 10 (descendiendo). Con "while"
using System;

class Ejercicio_02_02_01_02_02
{
    static void Main()
    {
        int n = 26;
        
        while (n >= 10)
        {
            Console.WriteLine(n);
            n = n - 2;
        }
    }
}
