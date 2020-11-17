// Lee una letra tecleada y dice si es signo de puntuación, cifra numérica u otro carácter. 
// Usando SWITCH

using System;

class Ej_09_01_09_02
{
    static void Main()
    {
        char letra;
        
        Console.WriteLine("Introduce una letra, número o signo:");
        letra = Convert.ToChar(Console.ReadLine());
        
        switch (letra)
        {
            case ' ':   Console.WriteLine("Espacio."); break;
            case '.':   Console.WriteLine("Punto."); break;
            case ',':   Console.WriteLine("Coma."); break;
            case ';':   Console.WriteLine("Punto y coma."); break;
            case ':':   Console.WriteLine("Dos puntos."); break;
            case '-':   Console.WriteLine("Guion."); break;
            case '0':   Console.WriteLine("Cero."); break;
            case '1':   Console.WriteLine("Uno."); break;
            case '2':   Console.WriteLine("Dos."); break;
            case '3':   Console.WriteLine("Tres."); break;
            case '4':   Console.WriteLine("Cuatro."); break;
            case '5':   Console.WriteLine("Cinco."); break;
            case '6':   Console.WriteLine("Seis."); break;
            case '7':   Console.WriteLine("Siete."); break;
            case '8':   Console.WriteLine("Ocho."); break;
            case '9':   Console.WriteLine("Nueve."); break;
            default:    Console.WriteLine("Otro carácter."); break;
        }
    }
}
