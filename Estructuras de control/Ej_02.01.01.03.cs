// Pide al usuario dos números enteros e indica si el primero es múltiplo del segundo

using System;

class Ejercicio_02_01_01_03
{
    static void Main()
    {
        int num1, num2;
        
        Console.Write("Introduce el primer número: ");
        num1 = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Introduce el segundo número: ");
        num2 = Convert.ToInt32(Console.ReadLine());
        
        if (num1 % num2 == 0)
        {
            Console.WriteLine("{0} es múltiplo de {1}", num1, num2);
        }
         if (num1 % num2 != 0)
        {
            Console.WriteLine("{0} NO es múltiplo de {1}", num1, num2);
        }
    }
}
