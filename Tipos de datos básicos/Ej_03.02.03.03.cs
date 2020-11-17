// Halla las soluciones de una ecuación de segundo grado.

using System;
class Ejercicio_03_02_03_03
{
 static void Main()
    {
        double a, b, c;
        double raiz, x, x2;
        Console.Write("Introduce el valor de A: ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Introduce el valor de B: ");
        b = Convert.ToInt32(Console.ReadLine());
        Console.Write("Introduce el valor de C: ");
        c = Convert.ToInt32(Console.ReadLine());
       
        raiz = b*b - 4*a*c;
        
        if (a == 0)
        {
            if (b != 0)
            {
                x = -c/b;
                Console.WriteLine("Ecuación de primer grado: x = {0}", x);
            }
            else
                Console.WriteLine("Ecuación errónea. A y B no pueden ser 0");
        }
        else if (raiz < 0)
            Console.WriteLine("No tiene solución", a, b, c);
        else
        {
            x = (-b + Math.Sqrt(raiz)) / (2*a);
            x2 = (-b - Math.Sqrt(raiz)) / (2*a);
            Console.WriteLine("x valdrá {0} y {1}", x, x2);
        }
       
       
       
    }
}
