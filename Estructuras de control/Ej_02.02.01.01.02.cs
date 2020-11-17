// Pide un número y calcula su cuadrado hasta que se introduce 0.

using System;

class Ejercicio_02_02_01_01_02
{
    static void Main()
    {
        int num;
        
        Console.WriteLine("Introduce un número (0 para salir)");
        num = Convert.ToInt32(Console.ReadLine());
        
        while (num != 0)
        {
            Console.WriteLine("El cuadrado de {0} es {1}", num, num*num);
            
            Console.WriteLine("Introduce otro número (0 para salir)");
            num = Convert.ToInt32(Console.ReadLine());                 
        }
        
        Console.WriteLine("HASTA LUEGO!");
    }
}
