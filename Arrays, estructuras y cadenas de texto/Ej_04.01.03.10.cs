/* Reserva espacio para dos vectores de 3 componentes. Pide los valores y 
 * calcula el producto escalar (x1·y1 + x2·y2 + x3·y3)
*/

using System;

class Ejercicio_04_01_03_10
{
    static void Main()
    {
        const int TAMANO = 3;
        int[] vectores1 = new int[TAMANO];
        int[] vectores2 = new int[TAMANO];
        int producto = 0;
        
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
        for (int i = 0; i < TAMANO; i++)
        {
            producto += vectores1[i] * vectores2[i];
        }
        Console.Write("Su producto escalar es: " + producto);
    }
}
