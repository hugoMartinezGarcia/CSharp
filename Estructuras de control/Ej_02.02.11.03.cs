// Escribe los números del 20 al 10, excepto el 13
// Sin usar "continue", sino el "if" contrario

using System;

class Ejercicio_02_02_11_03
{
    static void Main()
    {
        for (int i=20; i>=10; i--)
        {
            if (i != 13)
                Console.Write("{0} ", i);
        }
    }
}
