/* Crea un menú donde el usuario podrá escoger la opción 0, 1, 2 o 3 y se le 
 * mostará la opción escogida usando "switch".
 * Empleando constantes en vez de "números mágicos"
 * Hugo Martínez
 */

using System;

class Ejercicio_59b
{
    static void Main()
    {
        byte opcion;
        const byte JUGAR = 1, CARGAR = 2, PUNTUACIONES = 3, SALIR = 0; 

        Console.WriteLine("{0}. Jugar", JUGAR);
        Console.WriteLine("{0}. Cargar", CARGAR);
        Console.WriteLine("{0}. Ver mejores puntuaciones", PUNTUACIONES);
        Console.WriteLine("{0}. Salir", SALIR);
        Console.WriteLine();
        Console.WriteLine("Escoge una opción: ");
        opcion = Convert.ToByte(Console.ReadLine());
        
        switch (opcion)
        {
            case JUGAR: Console.WriteLine("Ha escogido la opción \"{0}\": " + 
                        "\"Jugar\"", opcion); break;
            case CARGAR: Console.WriteLine("Ha escogido la opción \"{0}\": " + 
                        "\"Cargar\"", opcion); break;
            case PUNTUACIONES: Console.WriteLine("Ha escogido la opción \"{0}\": " + 
                        "\"Ver mejores puntuaciones\"", opcion); break;
            case SALIR: Console.WriteLine("Ha escogido la opción \"{0}\": " + 
                        "\"Salir\"", opcion); break;
            default: Console.WriteLine("La opción escogida no es correcta");
                        break;
        }
        
        
        
        
    }
}
