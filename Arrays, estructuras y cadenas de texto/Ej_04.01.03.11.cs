/* Pide 4 números enteros y muestra cuál es el mayor de ellos.
*/

using System;

class Ejercicio_04_01_03_11
{
    static void Main()
    {
        const int TAMANO = 4;
        int[] numeros = new int[TAMANO];
        int numero, mayor;
        
        for (int i = 0; i < TAMANO; i++)
        {
            Console.Write("Introduce el {0}º número: ", i+1);
            numero = Convert.ToInt32(Console.ReadLine());
            
            numeros[i] = numero;
        }
        mayor = numeros[0];
        for (int i = 1; i < TAMANO; i++)
        {
            if (numeros[i] > mayor)
                mayor = numeros[i];
        }
        Console.WriteLine("El mayor es: " + mayor);
    }
}
