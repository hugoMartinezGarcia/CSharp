// "for" que muestra el abecedario en mayúscula de forma descendente

using System;

class Ejercicio_02_02_07_01
{
    static void Main()
    {
        char letra;
        
        for (letra='Z'; letra >='A'; letra--)
        {
            Console.WriteLine("{0} ", letra);
        }
    }
}
