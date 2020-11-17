// Escribe los números del 20 al 10, excepto el 13. Usando "continue"

using System;

class Ejercicio_02_02_11_01
{
    static void Main()
    {
        for (int i=20; i>=10; i--)
        {
            if (i == 13)
                continue;
                
            Console.Write("{0} ", i);
        }
    }
}
