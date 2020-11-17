// Calcula la raíz cuadrada de un número introducido por el usuario. 
// La calcula como double, pero la muestra como float.

using System;

class Ejercicio_03_02_04_01
{
    static void Main()
    {
        double raiz;
        int num;
        
        Console.Write("Introduce un número: ");
        num = Convert.ToInt32(Console.ReadLine());
       
        raiz = Math.Sqrt(num);
        
        Console.WriteLine((float)raiz);
    }
}
