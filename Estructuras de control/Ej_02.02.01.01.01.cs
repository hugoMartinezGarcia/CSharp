// Pide una contraseña numérica hasta que se introduce el número 1111.

using System;

class Ejercicio_02_02_01_01_01
{
    static void Main()
    {
        int contrasenya;
        
        Console.WriteLine("Introduce la contraseña: ");
        contrasenya = Convert.ToInt32(Console.ReadLine());
        
        while (contrasenya != 1111)
        {
            Console.WriteLine("Error. Introduce la contraseña de nuevo: ");
            contrasenya = Convert.ToInt32(Console.ReadLine());                 
        }
        
        Console.WriteLine("CONTRASEÑA CORRECTA!");
    }
}
