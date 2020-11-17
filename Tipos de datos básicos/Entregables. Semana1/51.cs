/* Pide dos números enteros cortos y muestra todos los números entre ellos, 
 * en hexadecimal separados por un espacio.
 * Hugo Martínez
*/

using System;

class Ejercicio_51
{
    static void Main()
    {
        byte num1, num2;
        
        Console.Write("Introduce el primer número: ");
        num1 = Convert.ToByte(Console.ReadLine());
        Console.Write("Introduce el segundo número: ");
        num2 = Convert.ToByte(Console.ReadLine());
        
        if (num1 <= num2 )
        {   
            for(int i=num1; i<=num2; i++)
                Console.Write("{0} ", i.ToString("X"));
        }        
        else 
        {
            for(int i=num2; i<=num1; i++)
                Console.Write("{0} ", i.ToString("X"));
        }
        Console.WriteLine();
    }
}
