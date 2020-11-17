/* Pide una serie de números enteros al usuario separados por espacios.
 * Después muestra los números que estén duplicados
 * Por Hugo Martínez
*/

using System;

class Ejercicio_67
{
    static void Main()
    {
        string numerosUsuario;
        bool encontrado = false;
        
        Console.WriteLine("Introduce algunos números separados por un espacio:");
        numerosUsuario = Console.ReadLine();
        
        string[] datos = numerosUsuario.Split();
        
        for (int i = 0; i < datos.Length; i++)
        {
            for (int j = i+1; j < datos.Length ;j++)
            {
                if (datos[i] == datos[j])
                {
                    if (!encontrado)
                    {
                        Console.Write("Duplicados: ");
                    }
                    Console.Write(datos[i] + " ");
                    encontrado = true;
                }
            }
        }
        if (!encontrado)
            Console.WriteLine("Duplicados: Ninguno");
    }
} 
