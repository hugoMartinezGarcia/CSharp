/* Pide al usuario un ancho, una altura y un carácter y muestra un 
 * trapecio descendente
 * Hugo Martínez
*/

using System;

class Ejercicio_58
{
    static void Main()
    {
        byte ancho, alto;
        char caracter;
        
        Console.Write("Introduce el ancho: ");
        ancho = Convert.ToByte(Console.ReadLine());
        Console.Write("Introduce la altura: ");
        alto = Convert.ToByte(Console.ReadLine());
        Console.Write("Introduce un caracter: ");
        caracter = Convert.ToChar(Console.ReadLine());
        
        for (int i=0; i<alto; i++)
        {
            for (int j=0; j<=i; j++)
            {
                Console.Write(" ");
            }
            for (int j=i*2; j<ancho+(alto-1)*2; j++)
            {
                Console.Write(caracter);
            }    
            Console.WriteLine();
        }
    }
}
