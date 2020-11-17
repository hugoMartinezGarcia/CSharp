// Vairante del ejemplo 02_01_06a con comparación de igualdad correcta
using System;

class Ejercicio_02_01_06_01
{
    static void Main()
    {
        int numero;
        
        Console.WriteLine("Introduce un número:");
        numero = Convert.ToInt32(Console.ReadLine());
        
        if (0 == numero)
        {
            Console.WriteLine("El número es cero");
        }
        else if (0 < numero)
        {
            Console.WriteLine("El número es positivo");
        }
        else
        {
            Console.WriteLine("El número es negativo");
        }
    }
}
