/* Crea un menú donde el usuario podrá escoger la opción 0, 1, 2 o 3 y se le 
 * mostará la opción escogida usando "switch".
 * EMPLEANDO UNA ENUMERACIÓN
 * Hugo Martínez
 */

using System;

class Ejercicio_59c
{
    enum opciones {SALIR, JUGAR, CARGAR, PUNTUACIONES}
    static void Main()
    {
        byte opcion;

        Console.WriteLine("{0}. Jugar", (byte) opciones.JUGAR);
        Console.WriteLine("{0}. Cargar", (byte)opciones.CARGAR);
        Console.WriteLine("{0}. Ver mejores puntuaciones", (byte)opciones.PUNTUACIONES);
        Console.WriteLine("{0}. Salir", (byte) opciones.SALIR);
        Console.WriteLine();
        Console.WriteLine("Escoge una opción: ");
        opcion = Convert.ToByte(Console.ReadLine());
        
        switch (opcion)
        {
            case (byte) opciones.JUGAR: 
                Console.WriteLine("Ha escogido la opción \"{0}\": \"Jugar\"", 
                    opcion); break;
            case (byte) opciones.CARGAR: 
                Console.WriteLine("Ha escogido la opción \"{0}\": \"Cargar\"", 
                    opcion); break;
            case (byte) opciones.PUNTUACIONES: 
                Console.WriteLine("Ha escogido la opción \"{0}\": " + 
                    "\"Ver mejores puntuaciones\"", opcion); break;
            case (byte)opciones.SALIR: 
                Console.WriteLine("Ha escogido la opción \"{0}\": \"Salir\"", 
                    opcion); break;
            default: Console.WriteLine("La opción escogida no es correcta");
                        break;
        }
    }
}
