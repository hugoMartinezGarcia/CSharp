// Pide dos números e indica cuál es el menor. Usando el OPERADOR CONDICIONAL.

using System;

class Ejemplo_02_01_08_02
{
    static void Main()
    {
        int num1, num2, resultado;
        
        Console.Write("Introduce un número: ");
        num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Introduce otro número: ");
        num2 = Convert.ToInt32(Console.ReadLine());
        
        resultado = num1 < num2 ? num1 : num2;
        
        Console.WriteLine("El menor de los números es {0}.", resultado);
    }
}
