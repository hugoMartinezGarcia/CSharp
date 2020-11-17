// Pide dos números y esribe sus divisores comunes.

using System;

class Ejercicio_02_02_09_02
{
    static void Main()
    {
        int numero1, numero2;
        int menor;
        
        Console.Write("Introduce un número: ");
        numero1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Introduce otro número: ");
        numero2 = Convert.ToInt32(Console.ReadLine());
        
        menor = numero1 < numero2 ? numero1 : numero2;
        
        for (int i = 1; i <= menor; i++)
        {
            if ((numero1 % i == 0) && (numero2 % i == 0))
            {
                Console.WriteLine("{0} y {1} son divisibles por {2}.", 
                    numero1, numero2, i);
            }
        }
        
    }
}
