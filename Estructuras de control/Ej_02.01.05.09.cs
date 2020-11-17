// Pide tres números e indica cuál es el mayor de los tres

using System;

class Ejercicio_02_01_05_09
{
    static void Main()
    {
        int num1, num2, num3;
        
        Console.Write("Introduce el primer número: ");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Introduce el segundo número: ");
        num2 = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Introduce el tercer número: ");
        num3 = Convert.ToInt32(Console.ReadLine());
        
        if ((num1 >= num2) && (num1 >= num3))
        {
            Console.WriteLine("{0} es el mayor número", num1);
        }
        else if ((num2 > num3) && (num2 > num1))
        {
            Console.WriteLine("{0} es el mayor número", num2);
        }
        else
        {
            Console.WriteLine("{0} es el mayor número", num3);
        }

    }
}
