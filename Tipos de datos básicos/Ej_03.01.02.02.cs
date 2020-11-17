// Pide al usuarios dos números de dos cifras "byte". Calcula su multiplicación, 
// que guardará en un int y muestra el resultado.

using System;

class Ejercicio_03_01_02_02
{
    static void Main()
    {
        byte numero1, numero2; 
        int resultado;
        
        Console.Write("Introduce el primer número de dos cifras: ");
        numero1 = Convert.ToByte(Console.ReadLine());
        Console.Write("Introduce el segundo número de dos cifras: ");
        numero2 = Convert.ToByte(Console.ReadLine());
        
        resultado = Convert.ToInt32(numero1 * numero2);
        
        Console.WriteLine("El resultado de la multiplicación es: {0}", resultado);    
    }
}
