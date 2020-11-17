// Cuanta cuántas veces aparece la letra 'a' en un texto introducido por el usuario
// Usando "foreach"

using System;

class Ejercicio_02_04_01
{
    static void Main()
    {
        string texto;
        int contador = 0;
        
        Console.WriteLine("Escribe una frase:");
        texto = Console.ReadLine();
        
        foreach (char letra in texto)
        {
            if (letra == 'a')
                contador++;
        }
        Console.WriteLine("El texto tiene {0} letras 'a'.", contador);
    }
}
