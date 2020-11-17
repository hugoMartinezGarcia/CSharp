// Pide al usuario dos números enteros e indica cual es el mayor

using System;

class Ejercicio_02_01_01_02
{
    static void Main()
    {
        int num1, num2;
        
        Console.Write("Introduce el primer número: ");
        num1 = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Introduce el segundo número: ");
        num2 = Convert.ToInt32(Console.ReadLine());
        
        if (num1 > num2)
        {
            Console.WriteLine("{0} es el mayor.", num1);
        }
        if (num1 < num2)
        {
            Console.WriteLine("{0} es el mayor.", num2); 
        }
         if (num1 == num2)
        {
            Console.WriteLine("Los números son iguales."); 
        }
    
    }
}
