/* Reserva espacio para dos vectores de 3 componentes. Pide los valores y 
 * calcula la suma de ambos (x1+y1, x2+y2, z1+z2)
*/

using System;

class Ejercicio_04_01_03_09
{
    static void Main()
    {
        const int TAMANO = 3;
        int[] vectores1 = new int[TAMANO];
        int[] vectores2 = new int[TAMANO];
        int[] suma = new int[TAMANO];
        
        for (int i = 0; i < TAMANO; i++)
        {
            Console.WriteLine("Introduce la {0}ª componente del primer vector:", 
                i+1);
            vectores1[i] = Convert.ToInt32(Console.ReadLine());
            
        }
        for (int i = 0; i < TAMANO; i++)
        {
            Console.WriteLine("Introduce la {0}ª componente del segundo vector:", 
                i+1);
            vectores2[i] = Convert.ToInt32(Console.ReadLine());
             
        }
        
        Console.Write("Su suma es: ");                
        for (int i = 0; i < TAMANO; i++)
        {
            suma[i] = vectores1[i] + vectores2[i];
            
            Console.Write(suma[i] + " ");                
        }
    }
}
