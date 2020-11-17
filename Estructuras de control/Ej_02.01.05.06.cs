// Pide dos números e indica si al menos uno es par

using System;

class Ejercicio_02_01_05_06
{
    static void Main()
    {
        int num1, num2;
        
        Console.Write("Introduce el primer número: ");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Introduce el segundo número: ");
        num2 = Convert.ToInt32(Console.ReadLine());
        
        if ((num1 % 2 == 0) || (num2 % 2 == 0))
        {
            Console.WriteLine("Al menos uno de los números es par.");
        }
        else
        {
            Console.WriteLine("Ninguno de los dos números es par.");
        }
    }
}
