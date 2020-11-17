// Pide dos números. Si el segundo es cero mostrará un error. Si no dará el resultado.
// Usando else

using System;

class Ejercicio_02_01_04_02
{
    static void Main()
    {
        int num1, num2;
       
        Console.Write("Introduce el primer número: ");
        num1 = Convert.ToInt32(Console.ReadLine());
       
        Console.Write("Introduce el segundo número: ");
        num2 = Convert.ToInt32(Console.ReadLine());
        
        if (num2 == 0)
        {
            Console.WriteLine("Error. No se puede dividir entre cero.");
        }
        else
        {
            Console.WriteLine("El resultado de dividir {0} entre {1} es {2}.", 
                num1, num2, num1/num2);
        }
        

       
    }
}
