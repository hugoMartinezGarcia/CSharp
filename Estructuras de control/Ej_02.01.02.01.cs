// Pide un número. Si es múltiplo de 10 lo indica y pide otro número e informa si es múltiplo de 10

using System;

class Ejercicio_02_01_02_01
{
    static void Main()
    {
        int num1, num2;
        
        Console.Write("Introduce un número: ");
        num1 = Convert.ToInt32(Console.ReadLine());
        
        if (num1 % 10 == 0)
        {
            Console.WriteLine("{0} es múltiplo de 10", num1);
            
            Console.Write("Introduce otro número: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            
            if (num2 % 10 == 0)
            {
                Console.WriteLine("{0} es múltiplo de 10", num2);
            }
        }
    }
}
