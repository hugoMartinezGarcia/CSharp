// Calcula la superficie y volumen de una esfera. Muestra 5 decimales.

using System;

class Ejercicio_03_02_05_04
{
    static void Main()
    {
        double superficie, volumen, radio;
        double pi = 3.141592654;
        
        Console.Write("Introduce el valor del radio: ");
        radio = Convert.ToDouble(Console.ReadLine());
        
        superficie = 4 * pi * radio*radio;
        volumen = 4/3 * pi * radio*radio*radio;
        
        Console.WriteLine("Su superficie es: {0}. Y su volumen es: {1}", 
            superficie.ToString("N5"), volumen.ToString("N5"));
    }
}
