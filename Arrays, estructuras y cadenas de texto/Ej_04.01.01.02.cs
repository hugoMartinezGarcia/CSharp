// Pide 5 números reales al usuario y los muestra en orden contrario.

using System;

class Ejercicio_04_01_01_02
{
    static void Main()
    {
        const int TOTAL_NUMEROS = 5;
        float[] numeros = new float[TOTAL_NUMEROS];
        
        Console.WriteLine("Introduce 5 números:");
        for (int i = 0; i < TOTAL_NUMEROS; i++)
        {
            numeros[i] = Convert.ToSingle(Console.ReadLine());
        }
        
        for (int i = TOTAL_NUMEROS - 1; i >= 0; i--)
        {
            Console.Write(numeros[i] + " ");
        }
        
    }
}
