// Pide un número al usuario y escribe los múltiplos de 9 que haya entre 1 y ese número.

using System;

class Ejercicio_02_02_09_01
{
    static void Main()
    {
        int numero;
        
        Console.Write("Introduce un número: ");
        numero = Convert.ToInt32(Console.ReadLine());
        
        for (int multiplo=1; multiplo<=numero; multiplo++)
        {
            if (multiplo % 9 == 0)
            {
                Console.Write("{0} ", multiplo);
            }
        }
    }
}
