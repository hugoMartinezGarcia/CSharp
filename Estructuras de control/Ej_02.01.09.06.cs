// Lee una letra e indica si es vocal, número, signo o consonante. Usando "if"

using System;

class Ej_09_01_09_06
{
    static void Main()
    {
        char letra;
        
        Console.WriteLine("Introduce un número del 1 al 10:");
        letra =  Convert.ToChar(Console.ReadLine());
        
        if ((letra == 'a') || (letra == 'e') || (letra == 'i') || 
            (letra == 'o') || (letra == 'u'))
        {
            Console.WriteLine("Vocal.");
        }
        else if ((letra >= '0') && (letra <= '9'))
        {
            Console.WriteLine("Número.");
        }
        else if ((letra == '.') || (letra == ',') || (letra == ';') || 
                (letra == ':') || (letra == '-'))
        {
            Console.WriteLine("Signo de puntuación.");
        }
        else
        {
            Console.WriteLine("Consonante.");
        }
    }
}
