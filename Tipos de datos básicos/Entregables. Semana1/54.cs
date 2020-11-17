/* Calcula una aproximación para PI. El usuario indicará cuántos términos desea 
 * Hugo Martínez
*/

using System;

class Ejercicio_54
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
            
            Console.WriteLine(piEntreCuatro * 4);
        }
        
    }
}
