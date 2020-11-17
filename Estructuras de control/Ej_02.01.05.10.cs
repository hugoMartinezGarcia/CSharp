// Pide dos números y dice si son iguales o indica cuál es mayor
using System;

class Ejercicio_02_01_05_10
{
    static void Main()
    {
        int num1, num2;
        
        Console.Write("Introduce el primer número: ");
        num1 = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Introduce el segundo número: ");
        num2 = Convert.ToInt32(Console.ReadLine());
        
        if (num1 == num2)
        {
            Console.WriteLine("Los dos números son iguales");
        }
        else if (num1 > num2)
        {
            Console.WriteLine("{0} es mayor que {1}", num1, num2);
        }
        else
        {
            Console.WriteLine("{0} es mayor que {1}", num2, num1);

        }

    }
}
