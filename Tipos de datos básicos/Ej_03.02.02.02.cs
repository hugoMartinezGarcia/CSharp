// Números reales: valor inicial de un float y de un double

using System;
class Ejercicio_03_02_02_02
{
    static void Main()
    {
        int radio;
        double pi = 3.141592653589793238;
        double area;
        
        Console.WriteLine("Introduce el valor del radio:");
        radio = Convert.ToInt32(Console.ReadLine());
        
        
        area = radio * radio * pi;
        Console.WriteLine("El área de un círculo de radio {0} es: {1}", 
            radio, area);
    
    }
}
