/* Crea un menú donde el usuario podrá escoger la opción 0, 1, 2 o 3 y se le 
 * mostará la opción escogida usando "switch"
 * Hugo Martínez
 */

using System;

class Ejercicio_59a
{
    static void Main()
    {
        byte opcion;

        Console.WriteLine("1. Jugar");
        Console.WriteLine("2. Cargar");
        Console.WriteLine("3. Ver mejores puntuaciones");
        Console.WriteLine("0. Salir");
        Console.WriteLine();
        Console.WriteLine("Escoge una opción: ");
        opcion = Convert.ToByte(Console.ReadLine());
        
        switch (opcion)
        {
            case 1: Console.WriteLine("Ha escogido la opción \"{0}\": " + 
                        "\"Jugar\"", opcion); break;
            case 2: Console.WriteLine("Ha escogido la opción \"{0}\": " + 
                        "\"Cargar\"", opcion); break;
            case 3: Console.WriteLine("Ha escogido la opción \"{0}\": " + 
                        "\"Ver mejores puntuaciones\"", opcion); break;
            case 0: Console.WriteLine("Ha escogido la opción \"{0}\": " + 
                        "\"Salir\"", opcion); break;
            default: Console.WriteLine("La opción escogida no es correcta");
                        break;
        }
        
        
        
        
    }
}
