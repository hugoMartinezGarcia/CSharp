// Pide un número al usuario y le dice si es par

using System;

class Ejercicio_02_01_01_01
{
    static void Main()
    {
        int num;
        
        Console.WriteLine("Escribe un número:");
        num = Convert.ToInt32(Console.ReadLine());
        
        if (num % 2 == 0)
        {
            Console.WriteLine("El número es par");
        }
        if (num % 2 != 0)
        {
            Console.WriteLine("El número es impar");
        }
    }
}
