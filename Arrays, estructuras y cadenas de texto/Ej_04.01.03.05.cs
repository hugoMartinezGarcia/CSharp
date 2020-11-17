/* Almacena en una tabla el número de días que tiene cada mes. Después pide al 
 * usuario un número de mes y un día e indica cuántos días quedan para final de
 * año.
 * Hugo Martínez.
*/

using System;

class Ejercicio_04_01_03_05
{
    static void Main()
    {
        int[] meses = {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
        int numMes, numDia;
        bool datosIncorrectos;
        
        do
        {
            Console.Write("Introduce el día: ");
            numDia = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Introduce el mes: ");
            numMes = Convert.ToInt32(Console.ReadLine());
            
            datosIncorrectos = numMes <= 0 || numMes > 12 || numDia <= 0 || 
                numDia > meses[numMes-1];
            
            if (datosIncorrectos)
            {
                Console.WriteLine("Datos incorrectos!");
            }
        }
        while (datosIncorrectos);
        
        for (int i = 0; i < numMes - 1; i++)
        {
            numDia += meses[i];
        }
        Console.WriteLine("Quedan {0} días hasta final de año.", 365 - numDia);
    }
}
