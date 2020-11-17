// Pide al usuario 4 números, los memoriza en un array y muestra los datos y su media

using System;

class Ejercicio_04_01_01_01
{
    static void Main()
    {
        const int TOTAL_NUMEROS = 4;
        int[] numeros = new int[TOTAL_NUMEROS];
        int suma= 0;
        float media;
        
        Console.WriteLine("Introduce 4 números:");
        
        for (int i = 0; i < TOTAL_NUMEROS; i++)
        {
            numeros[i] = Convert.ToInt32(Console.ReadLine());
            suma += numeros[i];
        }
        for (int i = 0; i < TOTAL_NUMEROS; i++)
        {
            Console.Write(numeros[i] + " ");
        }
        Console.WriteLine();
        media = (float) suma / TOTAL_NUMEROS;
        Console.WriteLine("Media = " + media);
        
       
    }
}
