// Pide el radio y calcula el volumen de una esfera usando doble precisión.

using System;
class Ejercicio_03_02_03_01
{
 static void Main()
    {
        double radio, volumen;
        float pi = 3.1415926f;
        
        Console.Write("Introduce el radio de la esfera: ");
        radio = Convert.ToDouble(Console.ReadLine());
        
        volumen = pi * radio * radio * radio * 4/3;
        Console.Write("El volumen de una esfera de radio {0} es {1}", 
            radio, volumen);

    }
}
