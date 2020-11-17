// Pide la cantidad de color en RGB y lo muestra en Hexadecimal.

using System;

class Ejemplo_03_02_06_02
{
    static void Main()
    {
        byte rojo, verde, azul;
        
            Console.WriteLine("Introduce la cantidad de color rojo:");
            rojo = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Introduce la cantidad de color verde:");
            verde = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Introduce la cantidad de color azul:");
            azul = Convert.ToByte(Console.ReadLine());
            
            Console.WriteLine("RGB: {0}{1}{2}", 
                rojo.ToString("X"), verde.ToString("X"), azul.ToString("X"));
    }
}
