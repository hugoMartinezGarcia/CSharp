// Pide al usuarios dos números enteros largos "long" y muestra su suma, su resta y su producto

using System;

class Ejercicio_03_01_02_03
{
    static void Main()
    {
        long numero1, numero2; 
        long suma, resta, producto;
        
        Console.Write("Introduce el primer número largo: ");
        numero1 = Convert.ToInt64(Console.ReadLine());
        Console.Write("Introduce el segundo número largo: ");
        numero2 = Convert.ToInt64(Console.ReadLine());
        
        suma = numero1 + numero2;
        resta = numero1 - numero2;
        producto = numero1 * numero2;
        
        Console.WriteLine("El resultado de su suma es: {0}", suma);    
        Console.WriteLine("El resultado de su suma es: {0}", resta);
        Console.WriteLine("El resultado de su suma es: {0}", producto);    
    }
}
