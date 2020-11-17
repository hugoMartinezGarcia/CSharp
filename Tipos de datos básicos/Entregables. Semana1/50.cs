/* Calcula el volumen de un cilindro a partir de su radio y su altura.
 * Usando float y mostrando el resultado con dos decimales.
 * Hugo Martínez
*/

using System;

class Ejercicio_50
{
    static void Main()
    {
        float radio, altura, volumen, pi = 3.14159265f;
        
        Console.Write("Introduce el radio: ");
        radio = Convert.ToSingle(Console.ReadLine());
        Console.Write("Introduce la altura: ");
        altura = Convert.ToSingle(Console.ReadLine());
        
        volumen = pi * radio*radio * altura;
        
        Console.WriteLine("El volumen del cilindro es: {0}", 
            volumen.ToString("N2"));
    }
}
