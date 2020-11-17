/* El usuario introducirá el radio y se calculará la longitud de la circunferencia.
 * Usando doble precisión.
 * Hugo Martínez
*/

using System;

class Ejercicio_49
{
    static void Main()
    {
        double radio, longitud, pi = 3.14159265359;
        
        Console.Write("Introduce el radio: ");
        radio = Convert.ToDouble(Console.ReadLine());
        
        longitud = 2 * pi * radio;
        
        Console.WriteLine("La longitud es: {0}", longitud);
    }
}
