// Cálculo del interés compuesto con la fórmula resultado=e(1+i)^n

using System;

class Ejercicio_03_02_03_04
{
    static void Main()
    {
        double resultado, euros;
        
        Console.WriteLine("Introduce el importe:");
        euros = Convert.ToDouble(Console.ReadLine());
        
        resultado = euros * Math.Pow(1+0.03,10);
        Console.WriteLine("En 10 años, al 3% anual, tendrás {0} euros", 
            resultado);
        
        
       
    }
}
