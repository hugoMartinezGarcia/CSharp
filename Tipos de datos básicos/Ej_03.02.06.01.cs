// Pide números en base 10 y muestra su equivalente en binario y en hexadecimal hasta que se introduce 0.

using System;

class Ejemplo_03_02_06_01
{
    static void Main()
    {
        int numero;

        do
        {
            Console.WriteLine("Introduce un número:");
            numero = Convert.ToInt32(Console.ReadLine());
            if (numero != 0)
            {
                Console.WriteLine("Hexadecimal: {0}", numero.ToString("X"));
                Console.WriteLine("Binario: {0}", Convert.ToString(numero, 2));
            }
        } while (numero != 0);
        Console.WriteLine("Fin del programa");
    }
}
