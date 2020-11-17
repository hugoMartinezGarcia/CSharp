/* Pregunta al usuario su nombre y responde "Hola, (seguido del nombre)" o 
 * "No te conozco, (seguido del nombre)".
 * Hugo Martínez
 */

using System;

class Ejercicio_56
{
    static void Main()
    {
        string nombre;
        
        Console.Write("Introduce tu nombre: ");
        nombre = Console.ReadLine();
        
        if (nombre == "Hugo")
        {
            Console.WriteLine("Hola, {0}.", nombre);
        }
        else
        {
            Console.WriteLine("No te conozco, {0}.", nombre);
        }
    }
}
