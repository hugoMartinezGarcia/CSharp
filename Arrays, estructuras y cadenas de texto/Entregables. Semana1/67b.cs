/* Versión más compleja del ejercicio 67 donde se soluciona el error que ocasiona
 * que el usuario introduzca el mismo número más de dos veces.
 * Se crea un nuevo array con los números duplicados, donde solo se guarda un 
 * duplicado si no está ya previamente en el array. Finalmente solo hay que 
 * mostrar el array.
 * Por Hugo Martínez
*/

using System;

class Ejercicio_67b
{
    static void Main()
    {
        string numerosUsuario;
        int cantidadDuplicados = 0;
        bool duplicado;
        
        Console.WriteLine("Introduce algunos números separados por un espacio:");
        numerosUsuario = Console.ReadLine();
        
        string[] datos = numerosUsuario.Split();
        // Nuevo array para almacenar los datos que se encuentren duplicados
        string[] duplicados = new string[datos.Length / 2];
        
        for (int i = 0; i < datos.Length; i++)
        {
            for (int j = i+1; j < datos.Length ;j++)
            {
                if (datos[i] == datos[j])
                {
                    duplicado = false;
                    for (int k = 0; k < cantidadDuplicados; k++)
                    {
                        if (datos[i] == duplicados[k])
                        {
                            duplicado = true;
                        }
                    }
                    if (!duplicado)
                    {
                        duplicados[cantidadDuplicados] = datos[i];
                        cantidadDuplicados++;
                    }
                }
            }
        }
        if (cantidadDuplicados > 0)
        {
            Console.Write("Duplicados: ");
            for (int k = 0; k < cantidadDuplicados; k++)
            {
                Console.Write(duplicados[k] + " ");
            }
        }
        else
        {
            Console.WriteLine("Duplicados: Ninguno");
        }
    }
} 
