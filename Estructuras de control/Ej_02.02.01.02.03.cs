// Calcula cuántas cifras tiene un número entero positivo. Usando "while"
using System;

class Ejercicio_02_02_01_02_03
{
    static void Main()
    {
        int n, cifras = 0;
        
        Console.WriteLine("Introduce un número:");
        n = Convert.ToInt32(Console.ReadLine());
        
        while (n >= 1)
        {
            cifras = cifras + 1;
            n = n / 10; 
        }
        Console.WriteLine("El número tiene {0} cifra(s)", cifras);
    }
}
