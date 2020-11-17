// Pide usuario y contraseña hasta que se introducen los correctos

using System;

class Ejercicio_02_02_02_04
{
    static void Main()
    {
        int ident = 1234, contrasenya = 1111, identUsu, contraUsu;
        
        do
        {
            Console.WriteLine("Introduce el usuario:");
            identUsu = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduce la contraseña:");
            contraUsu = Convert.ToInt32(Console.ReadLine());
           
            if ((identUsu != ident) || (contraUsu != contrasenya))
            {
                Console.WriteLine("Usuario o contraseña incorrectos.");                
            }
        }
        while ((identUsu != ident) || (contraUsu != contrasenya));
        
        Console.WriteLine("Usuario y contraseña correctos.");
    
    }
}

