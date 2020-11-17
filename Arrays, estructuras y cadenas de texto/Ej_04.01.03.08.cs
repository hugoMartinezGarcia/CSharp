/* Reserva espacio para un vector de 3 componentes. Pide los valores y muestra
 * su módulo (raíz cuadrada de la suma de sus componentes al cuadrado)
*/

using System;

class Ejercicio_04_01_03_08
{
    static void Main()
    {
        int[] componentes = new int[3];
        double modulo = 0;
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("Introduce la {0}ª componente del vector:", i+1);
            componentes[i] = Convert.ToInt32(Console.ReadLine());
            
            modulo += Math.Pow(componentes[i],2);
        }
        modulo = (double) Math.Sqrt(modulo);
        
        Console.WriteLine("El módulo del vector es: {0}", modulo);
    }
}
