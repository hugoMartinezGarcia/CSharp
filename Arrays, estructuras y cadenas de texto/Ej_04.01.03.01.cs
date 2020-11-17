// Almacena en un arra el número de días de cada mes. Después pide al usuario el 
// número de mes y le indica cuántos días tiene.  

using System;

class Ejercicio_04_01_03_01
{
    static void Main()
    {
        int mes;
        int [] meses = {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
        
        Console.WriteLine("Introduce el número de mes:");
        mes = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("El {0}º mes tiene {1} dias.", mes, meses[mes - 1]);
        
    }
}
