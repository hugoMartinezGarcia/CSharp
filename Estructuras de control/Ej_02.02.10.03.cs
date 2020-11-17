// Pide dos números y muestra el M.C.D. con "while" y sin usar "break"

using System;

class Ejercicio_02_02_10_03
{
    static void Main()
    {
        int numero1, numero2, menor;
        
        Console.Write("Introduce el primer número: ");
        numero1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Introduce el segundo número: ");
        numero2 = Convert.ToInt32(Console.ReadLine());
        
        menor = (numero1 < numero2) ? numero1 : numero2;
        
        while ((menor > 0) && ((numero1 % menor != 0) || (numero2 % menor != 0)))
        {
            menor--;
        }
        Console.WriteLine("El M.C.D. es {0}", menor);
    }
}
