// Pide un número y muestra su valor absoluto. Usando el OPERADOR CONDICIONAL.

using System;

class Ejemplo_02_01_08_01
{
    static void Main()
    {
        int num, resultado;
        
        Console.Write("Introduce un número: ");
        num = Convert.ToInt32(Console.ReadLine());
        
        resultado = num >= 0 ? num : num * (-1);
        Console.WriteLine("El valor absoluto es {0}.", resultado);
    }
}
