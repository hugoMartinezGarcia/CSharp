// Muestra los números del 1 al 50 que sean múltiplos de 3.

using System;

class Ejercicio_02_02_03_02
{
    static void Main()
    {
        int contador;
        
        for (contador = 1; contador <= 50; contador++)
        {
            if (contador % 3 == 0)
                Console.Write("{0} ", contador);
        }
    }
}
