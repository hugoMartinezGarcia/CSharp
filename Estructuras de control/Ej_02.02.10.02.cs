// Pide dos números y muestra el mínimo común múltiplo

using System;

class Ejercicio_02_02_10_02
{
    static void Main()
    {
        int numero1, numero2, mayor;
        
        Console.Write("Introduce el primer número: ");
        numero1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Introduce el segundo número: ");
        numero2 = Convert.ToInt32(Console.ReadLine());
        
        mayor = numero1 > numero2 ? numero1 : numero2;
        
        for (int i = mayor; i < 100000; i++)
        {
            if ((i % numero1 == 0) && (i % numero2 == 0))
            {
                Console.WriteLine("El m.c.m. es {0}", i);
                break;
            }
        }
        

        
    }
}
