/* Prepara espacio para guardar 100 nombres. Se pedirán nombres hasta que el
 * usuario pulse intro sin introducir nada. En ese momento se mostrarán todos 
 * los nombres introducidos.
*/

using System;

class Ejercicio_04_01_03_07
{
    static void Main()
    {
        string[] nombres = new string[100];
        bool continuar;
        int cantidad = 0;
        do
        {
            Console.WriteLine("Introduce un nombre:");
            nombres[cantidad] = Console.ReadLine();
  
            continuar = nombres[cantidad] != "" && cantidad <= 100;
            cantidad++; 
        }
        while (continuar);
        
        for (int i = 0; i < cantidad; i++)
        {
            Console.Write(nombres[i] + " ");
        }
    }
}
