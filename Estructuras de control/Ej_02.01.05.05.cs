// Pide dos números e indica si ambos son pares

using System;

class Ejercicio_02_01_05_05
{
    static void Main()
    {
        int num1, num2;
        
        Console.Write("Introduce el primer número: ");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Introduce el segundo número: ");
        num2 = Convert.ToInt32(Console.ReadLine());
        
        if ((num1 % 2 == 0) && (num2 % 2 == 0))
        {
            Console.WriteLine("Ambos números son pares");
        }
        else 
        {
            Console.WriteLine("Al menos uno de los números no es par");
        }
    }
}
