// Muestra la tabla de multiplicar del 9

using System;

class Ejercicio_02_02_03_04
{
    static void Main()
    {
        int contador;
        
        for (contador = 0; contador <= 10; contador++)
        {
                Console.WriteLine("9 x {0} = {1} ", contador, 9 * contador);
        }
    }
}
