// Muestra los primeros 8 números pares.

using System;

class Ejercicio_02_02_03_05
{
    static void Main()
    {
        int contador;
        
        for (contador = 2; contador <= 16; contador += 2)
        {
                Console.Write("{0} ", contador);
        }
    }
}
