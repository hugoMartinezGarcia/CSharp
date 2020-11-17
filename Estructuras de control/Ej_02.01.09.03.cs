// Lee una letra tecleada y dice si es vocal, consonante o cifra numérica. 
// Usando SWITCH

using System;

class Ej_09_01_09_03
{
    static void Main()
    {
        char letra;
        
        Console.WriteLine("Introduce una letra, número o signo:");
        letra = Convert.ToChar(Console.ReadLine());
        
        switch (letra)
        {
            case 'a':
            case 'e':
            case 'i':
            case 'o':               
            case 'u':   Console.WriteLine("Vocal"); 
                        break;
            case '0':
            case '1':
            case '2':
            case '3':
            case '4':
            case '5':
            case '6':
            case '7':
            case '8':
            case '9':   Console.WriteLine("Cifra numérica."); 
                        break;
            default:    Console.WriteLine("Consonante."); 
                        break;
        }
    }
}
