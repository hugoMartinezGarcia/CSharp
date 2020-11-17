/* El usuario intenta adivinar un número del 1 al 100. 
 * Se le indica si se pasa o se queda corto
 */

using System;

class Ejercicio_02_05_02
{
    static void Main()
    {
        int numero = 67, numUsuario;
        
        do
        {
            Console.Write("Intenta adivinar un número entre 1 y 100: ");
            numUsuario = Convert.ToInt32(Console.ReadLine());
            if (numUsuario > numero)
                Console.WriteLine("Te pasaste.");
            else if (numUsuario < numero)
                Console.WriteLine("Te has quedado corto.");
            else
                Console.WriteLine("Has acertado.");
            Console.WriteLine();
        }
        while (numUsuario != numero);
    }
}
