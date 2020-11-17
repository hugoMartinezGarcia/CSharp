/* Pide un número entero largo y responde cuántas cifras tiene
 * Hugo Martínez
*/

using System;

class Ejercicio_53
{
    static void Main()
    {
        long numero;
        int cifras = 1;
       
        Console.Write("Introduce un número: ");
        numero = Convert.ToInt64(Console.ReadLine());
        
        while (numero / 10 >= 1)
        {
            numero /= 10;
            cifras++;
        }
        Console.WriteLine("El número tiene {0} cifras.", cifras);
    }
}
