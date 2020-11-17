// Pide la cantidad de color en RGB y lo muestra en Hexadecimal.

using System;

class Ejemplo_03_02_06_03
{
    static void Main()
    {
        int num = 0;
        
            for (int i=1; i<=256; i++)
            {
                Console.Write(num.ToString("X") + " ");
                
                if ((i % 16 == 0) && (i > 0))
                    Console.WriteLine();
                num++;
            }
    }
}
