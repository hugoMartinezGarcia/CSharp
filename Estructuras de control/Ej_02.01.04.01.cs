// Multiplica dos números. Si el primer número es 0 marca error y no pide el segundo.
// Usando else

using System;

class Ejercicio_02_01_04_01
{
    static void Main()
    {
        int num1, num2;
       
        Console.Write("Introduce el primer número: ");
        num1 = Convert.ToInt32(Console.ReadLine());
       
        if (num1 == 0)
        {
            Console.WriteLine("El producto de 0 por cualquier número es 0");
        }
        else
        {
            Console.Write("Introduce el segundo número: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("{0}x{1}={2}", num1, num2, num1*num2);
        }
    }
}
