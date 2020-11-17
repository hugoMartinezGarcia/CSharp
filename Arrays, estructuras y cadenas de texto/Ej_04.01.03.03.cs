// Pide 10 números reales de doble precisión, calcula su media y muestra los que 
// estén por encima de la media.

using System;

class Ejercicio_04_01_03_03
{
    static void Main()
    {
        double [] numeros = new double [10];
        double suma = 0, media;
        
        
        
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Introduce el {0}º número:", i+1);
            numeros[i] = Convert.ToDouble(Console.ReadLine());
            suma += numeros[i];
        }
        media = suma / 10;
        
        Console.WriteLine("La media de los números introducidos es: " + media);
        
        for (int i = 0; i < 10; i++)
        {
            if (numeros[i] > media)
            {
                Console.WriteLine(numeros[i]);
            }
        }
    }
}
