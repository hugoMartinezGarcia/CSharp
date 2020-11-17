/* Pide un número binario al usuario y muestra su equivalente en decimal
 * Hugo Martínez
*/

using System;

class Ejercicio_53
{
    static void Main()
    {
        ulong n, cifra;
        int suma = 0, potencia = 1;
        
        Console.WriteLine("Introduce un número binario:");
        n = Convert.ToUInt64(Console.ReadLine());
        
        while (n > 0)
        {
            cifra = n % 10;
            if (cifra == 1)
                suma += potencia;
                
            n /= 10;
            potencia *= 2;
        }
        
        Console.WriteLine("El número es {0}", suma);
        
        
        
    }
}
