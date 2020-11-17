//Pide un número del 1 al 10 y escribe el nombre del número. Usando SWITCH

using System;

class Ej_09_01_09_01
{
    static void Main()
    {
        int num;
        
        Console.WriteLine("Introduce un número del 1 al 10:");
        num = Convert.ToInt32(Console.ReadLine());
        
        switch (num)
        {
            case 1: Console.WriteLine("Uno"); break;
            case 2: Console.WriteLine("Dos"); break;
            case 3: Console.WriteLine("Tres"); break;
            case 4: Console.WriteLine("Cuatro"); break;
            case 5: Console.WriteLine("Cinco"); break;
            case 6: Console.WriteLine("Seis"); break;
            case 7: Console.WriteLine("Siete"); break;
            case 8: Console.WriteLine("Ocho"); break;
            case 9: Console.WriteLine("Nueve"); break;
            case 10: Console.WriteLine("Diez"); break;
            default: Console.WriteLine("No se reconoce el número"); break;
            
        }
    }
}
