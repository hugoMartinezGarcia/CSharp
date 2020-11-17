// Pide al usuario un número y le indica si es múltiplo de 2 y de 3, de alguno de ellos o de ninguno.
// Usando else

using System;

class Ejercicio_02_01_05_01234
{
    static void Main()
    {
        int num;
        
        Console.Write("Introduce un número: ");
        num = Convert.ToInt32(Console.ReadLine());
        
        if ((num % 2 == 0) && (num % 3 == 0))
        {
            Console.WriteLine("{0} es múltiplo de 2 y de 3", num);
        }
        else if ((num % 2 != 0) && (num % 3 != 0))
        {
            Console.WriteLine("{0} NO es múltiplo de 2 ni de 3", num);
        }
        else if ((num % 2 != 0) && (num % 3 == 0))
        {
            Console.WriteLine("{0} NO es múltiplo de 2, pero sí de 3", num);
        }
        else
        {
            Console.WriteLine("{0} es múltiplo de 2, pero no de 3", num);
        }
    }
}
