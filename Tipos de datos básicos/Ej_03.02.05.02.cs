// Pide tres números y muestra el resultado de una ecuación con dos decimales

using System;

class Ejercicio_03_02_05_02
{
    static void Main()
    {
        float x, y, z, resultado;
        
        Console.Write("Introduce el valor de x: ");
        x = Convert.ToSingle(Console.ReadLine());
        Console.Write("Introduce el valor de y: ");
        y = Convert.ToSingle(Console.ReadLine());
        Console.Write("Introduce el valor de z: ");
        z = Convert.ToSingle(Console.ReadLine());
        
        resultado = x*x + y - z;
        
        Console.WriteLine(resultado.ToString("N2"));
    }
}
