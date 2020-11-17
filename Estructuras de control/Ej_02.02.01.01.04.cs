// Pide dos números e indica si el primero es múltiplo del segundo. Hasta que alguno sea 0.

using System;

class Ejercicio_02_02_01_01_04
{
    static void Main()
    {
        int num1, num2;
        
        Console.Write("Introduce el primer número (0 para salir): ");
        num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Introduce el segundo número (0 para salir): ");
        num2 = Convert.ToInt32(Console.ReadLine());

        while ((num1 != 0) && (num2 != 0)) 
        {
            if (num1 % num2 == 0)
            {
                Console.WriteLine("{0} es múltiplo de {1}", num1, num2);
            }                
            else if (num2 % num1 == 0)
            {
                Console.WriteLine("{0} es múltiplo de {1}", num2, num1);
            }
            else
            {
                Console.WriteLine("Ninguno es múltiplo del otro");                
            }
            Console.Write("Introduce el primer número (0 para salir): ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduce el segundo número (0 para salir): ");
            num2 = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("HASTA LUEGO!");
    }
}
