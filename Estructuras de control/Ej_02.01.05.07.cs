// Pide dos números e indica si uno y solo uno es par.

using System;

class Ejercicio_02_01_05_07
{
    static void Main()
    {
        int num1, num2;
        
        Console.Write("Introduce el primer número: ");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Introduce el segundo número: ");
        num2 = Convert.ToInt32(Console.ReadLine());
        
        if (((num1 % 2 == 0) && (num2 % 2 != 0)) || 
            ((num1 % 2 != 0) && (num2 % 2 == 0)))
        {
            Console.WriteLine("Solo uno de los números es par.");
        }
    }
}
