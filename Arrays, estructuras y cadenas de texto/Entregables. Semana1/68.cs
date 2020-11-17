/* Pide un número entero positivo y muestra su equivalente en forma binaria.
 * Por Hugo Martínez
*/

using System;

class Ejercicio_68
{
    static void Main()
    {
        const int TAMANO = 8;
        int[] numeros = new int[TAMANO];
        int numero;
        
        Console.WriteLine("Introduce un número:");
        numero = Convert.ToInt32(Console.ReadLine());
        
        for (int i = TAMANO - 1; i >= 0; i--)
        {
            numeros[i] = numero % 2;
            numero /= 2;
        }
        
        for (int i = 0; i < TAMANO; i++)
        {
            Console.Write(numeros[i]);
        }
    }
}
