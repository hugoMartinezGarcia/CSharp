// Pide dos números y escribe su máximo común divisor

using System;

class Ejercicio_02_02_10_01
{
    static void Main()
    {
        int numero1, numero2, menor;
        
        Console.Write("Introduce el primer número: ");
        numero1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Introduce el segundo número: ");
        numero2 = Convert.ToInt32(Console.ReadLine());
        
        menor = numero1 < numero2 ? numero1 : numero2;
        
        for (int i = menor; i > 0; i--)
        {
            if ((numero1 % i == 0) && (numero2 % i == 0))
            {
                Console.WriteLine("El M.C.D. es {0}", i);
                break;
            }
        }
        

        
    }
}
