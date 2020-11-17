// Muestra el resultado de las operaciones abreviadas

using System;

class Ejercicio_03_01_04_02
{
    static void Main()
    {
        int a, b, c;
        a=5;
        b=a+2;
        b-=3;
        c=-3;
        c*=2;
        ++c;
        a*=b;
        
        
        Console.WriteLine("a = {0}", a);
        Console.WriteLine("b = {0}", b);
        Console.WriteLine("c = {0}", c);    
    }
}
