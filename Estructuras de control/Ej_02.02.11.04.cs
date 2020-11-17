// Escribe los números pares del 2 al 106, excepto los múltiplos de 10.
// Sin usar "continue", sino el "if" contrario

using System;

class Ejercicio_02_02_11_04
{
    static void Main()
    {
        for (int i=2; i<=106; i++)
        {
            if (i % 10 != 0)
                Console.Write("{0} ", i);
        }
    }
}
