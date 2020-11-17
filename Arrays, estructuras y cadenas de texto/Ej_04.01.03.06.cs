/* Pide 10 nombres y los memoriza. Después pedirá un nombre y dirá si se encuentra 
 * entre los tecleados antes. Seguirá pidiendo hasta que se teclee "fin".
*/

using System;

class Ejercicio_04_01_03_06
{
    static void Main()
    {
        string[] nombres = new string[10];
        string nombre;
        bool continuar;
        bool encontrado = false;
        
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Introduce el {0}º nombre: ", i+1);
            nombres[i] = Console.ReadLine();
        }
        
        do
        {
            Console.WriteLine();
            Console.WriteLine("Introduce el nombre a buscar:");
            nombre = Console.ReadLine();
            for (int i = 0; i < 10; i++)
            {
                if (nombres[i] == nombre)
                    encontrado = true;
            }
            Console.WriteLine();
            if (encontrado)
                Console.WriteLine("Se ha encontrado el nombre");
            else
                Console.WriteLine("El nombre no se ha encontrado");

            continuar = nombre != "fin"; 
        }
        while (continuar);
        
        Console.WriteLine("Hasta luego!");

        
        
    }
}
