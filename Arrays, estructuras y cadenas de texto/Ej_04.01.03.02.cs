// Pregunta al usuario cuántos números va a introducir y le pide todos esos números,
// los guarda en un array y muestra su media.

using System;

class Ejercicio_04_01_03_02
{
    static void Main()
    {
        int [] numeros;
        int suma = 0, tamanyo; 
        float media;
        
        Console.Write("¿Cuántos números desea introducir?: ");
        tamanyo = Convert.ToInt32(Console.ReadLine());
        
        numeros = new int[tamanyo];
        
        for (int i = 0; i < tamanyo; i++)
        {
            Console.WriteLine("Introduce el {0}º número:", i+1);
            numeros[i] = Convert.ToInt32(Console.ReadLine());
            suma += numeros[i];
        }
        media = (float) suma / tamanyo;
        Console.WriteLine("La media de los números introducidos es: " + media);
    }
}
