/* Pide 10 enteros largos al usuario y los guarda en un array. Después pide uno
 * más y dice si estaba entre los datos iniciales. 
 * Utilizando un booleano y después un contador para indicar el número de veces
 * que aparece.
 * Por Hugo Martínez.
*/

using System;

class Ejercicio_63
{
    static void Main()
    {
        const int TAMANO = 10;
        long[] numeros = new long[TAMANO];
        long numeroABuscar;
        bool encontrado = false;
        int vecesRepetido = 0;
        
        for (int i = 0; i < TAMANO; i++)
        {
            Console.Write("Introduce el {0}º número: ", i+1);
            numeros[i] = Convert.ToInt64(Console.ReadLine());
        }
        Console.WriteLine();
        Console.WriteLine("Introduce el número a buscar:");
        numeroABuscar = Convert.ToInt64(Console.ReadLine());
        
        // Primero usamos un booleano para comprobar si el número aparece
        for (int i = 0; i < TAMANO; i++)
        {
            if (numeros[i] == numeroABuscar)
            {
                encontrado = true;
            }
        }
        if (encontrado)
            Console.WriteLine("El número se encuentra en el array.");
        else
            Console.WriteLine("El número no se ha encontrado.");

        // Ahora usamos un contador para poder decir cuántas veces se repite
        for (int i = 0; i < TAMANO; i++)
        {
            if (numeros[i] == numeroABuscar)
            {
                vecesRepetido++;
            }
        }
        if (vecesRepetido > 0)
            Console.WriteLine("El número está repetido {0} veces.", 
                vecesRepetido);
        else
            Console.WriteLine("El número no se ha encontrado.");
    }
}
