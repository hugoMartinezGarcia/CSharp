// Pide dos números y muestra el m.c.m con "while" y sin usar "break"

using System;

class Ejercicio_02_02_10_04
{
    static void Main()
    {
        int numero1, numero2, mayor;
        
        Console.Write("Introduce el primer número: ");
        numero1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Introduce el segundo número: ");
        numero2 = Convert.ToInt32(Console.ReadLine());
        
        mayor = (numero1 > numero2) ? numero1 : numero2;
        
        while ((mayor % numero1 != 0) || (mayor % numero2 != 0))
        {
            mayor++;
        }
        Console.WriteLine("El m.c.m. es {0}", mayor);
    }
}
