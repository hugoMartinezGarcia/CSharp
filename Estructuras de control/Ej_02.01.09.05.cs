// Lee una letra e indica si es signo, número u otro carácter. Usando "if"

using System;

class Ej_09_01_09_05
{
    static void Main()
    {
        char letra;
        
        Console.WriteLine("Introduce un número del 1 al 10:");
        letra =  Convert.ToChar(Console.ReadLine());
        
        if ((letra >= '0') && (letra <= '9'))
        {
            Console.WriteLine("Número.");
        }
        else if (letra == '.')
        {
            Console.WriteLine("Punto.");
        }
        else if (letra == ',')
        {
            Console.WriteLine("Coma.");
        }
        else if (letra == ';')
        {
            Console.WriteLine("Punto y coma.");
        }
        else if (letra == ':')
        {
            Console.WriteLine("Dos puntos.");
        }
        else
        {
            Console.WriteLine("Otro carácter.");
        }



    }
}
