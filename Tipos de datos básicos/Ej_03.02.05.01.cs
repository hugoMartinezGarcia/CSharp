// Divide dos números reales tecleados por el usuario y muestra el resultado con 3 cifras decimales.

using System;

class Ejercicio_03_02_05_01
{
    static void Main()
    {
        double dividendo, divisor, resultado;
        
        Console.Write("Introduce el dividendo: ");
        dividendo = Convert.ToDouble(Console.ReadLine());
        Console.Write("Introduce el divisor: ");
        divisor = Convert.ToDouble(Console.ReadLine());
        
        if (divisor != 0)
        {
            resultado = dividendo / divisor;
            Console.WriteLine(resultado.ToString("0.000"));
        }
        else
            Console.WriteLine("No se puede dividir por 0.");
    }
}
