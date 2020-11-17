// Pide números positivos y va mostrando la suma de todos ellos hasta que se introduce cero o negativo

using System;

class Ejercicio_02_02_02_01
{
    static void Main()
    {
        int num, suma = 0;
        
        do
        {
            Console.WriteLine("Introduce un número para sumar (0 o negativo para salir):");
            num = Convert.ToInt32(Console.ReadLine());
            
            if (num > 0)
            {
                suma = suma + num;
            }
            Console.WriteLine("El total es {0}", suma);
        }
        while (num > 0);
        
        Console.WriteLine("Fin del programa.");
    }
}

