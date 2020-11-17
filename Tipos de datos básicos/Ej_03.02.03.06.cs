// Dibuja la gráfica y = (x-5)^2 para valores de x entre 1 y 10.

using System;

class Ejercicio_03_02_03_06
{
    static void Main()
    {
        float y;
        
        for (int x=1; x <=10; x++)
        {
            y = (x-5)*(x-5);
            for (int i=0; i<y; i++)
            {
                Console.Write(" ");
            }
            Console.WriteLine("*");
        }
    }
}
