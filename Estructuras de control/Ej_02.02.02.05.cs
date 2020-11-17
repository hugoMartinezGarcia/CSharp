// Pide usuario y contraseña hasta que se escribe usuario: Pedro y contraseña: Peter.
// usando string

using System;

class Ejercicio_02_02_02_05
{
    static void Main()
    {
        string ident = "Pedro", contrasenya = "Peter", identUsu, contraUsu;
        
        do
        {
            Console.WriteLine("Introduce el usuario:");
            identUsu = Console.ReadLine();
            Console.WriteLine("Introduce la contraseña:");
            contraUsu = Console.ReadLine();
            
            if ((identUsu != ident) || (contraUsu != contrasenya))
            {
                Console.WriteLine("Usuario o contraseña incorrectos.");                
            }
        }
        while ((identUsu != ident) || (contraUsu != contrasenya));
        
        Console.WriteLine("Usuario y contraseña correctos.");
    
    }
}

