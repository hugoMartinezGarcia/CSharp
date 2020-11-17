// Pide dos números e indica si uno es positivo, los dos o ninguno.

using System;

class Ejercicio_02_01_05_08
{
    static void Main()
    {
        int num1, num2;
        
        Console.Write("Introduce el primer número: ");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Introduce el segundo número: ");
        num2 = Convert.ToInt32(Console.ReadLine());
        
        if ((num1 >= 0) && (num2 >= 0))
        {
            Console.WriteLine("Los dos números son positivos o 0");
        }
        else if ((num1 < 0) && (num2 < 0))
        {
            Console.WriteLine("Ninguno de los números es positivo o 0");
        }
        else
        {
            Console.WriteLine("Uno de los números es positivo o 0");
        }

    }
}
