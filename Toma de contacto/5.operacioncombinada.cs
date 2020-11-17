// Hugo Martínez
// Resultado de una operación combinada

using System;

class opercombi
{
    static void Main()
    {
        /* Ponemos 12.0 para que la división no se tome como una división
         * entre enteros y el resultado arroje decimales*/
        Console.WriteLine("(50-12/5+2*3)%7 es: {0}", (50-12.0/5+2*3)%7);
    }
        
}
