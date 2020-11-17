// Incrementa el valor de tres variables y muestra su resultado.

using System;

class Ejercicio_03_01_03_01
{
    static void Main()
    {
        int x = 15, y = -10, z = 2147483647;
 
        x++;
        y++;
        z++;
        
        Console.WriteLine("x = {0}", x);
        Console.WriteLine("y = {0}", y);
        // En un int el máximo valor es el asignado a z inicialmente. 
        // Al incrementarlo mostrará el último valor negativo
        Console.WriteLine("z = {0}", z);    
    }
}
