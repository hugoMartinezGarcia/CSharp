// Calcula una aproximación de PI mediante la expresión pi/4 = 1/1 - 1/3 + 1/5 - 1/7...

using System;

class Ejercicio_03_02_04_02
{
    static void Main()
    {
        double piEntreCuatro = 0, denominador = 1;
        int signo = 1, aproximacion;
        
        Console.Write("Indica los términos de aproximación: ");
        aproximacion = Convert.ToInt32(Console.ReadLine());
    
        for (int i=0; i<aproximacion; i++)
        {
            piEntreCuatro += signo / denominador;
            
            signo *= (-1);
            denominador+=2;
        }
        Console.WriteLine((float)piEntreCuatro * 4);
    }
}
