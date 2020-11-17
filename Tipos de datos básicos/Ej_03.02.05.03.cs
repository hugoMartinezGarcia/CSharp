// Calcula el perímetro, área y diagonal de un rectángulo y los muestra con un decimal

using System;

class Ejercicio_03_02_05_03
{
    static void Main()
    {
        float perimetro, area, ancho, alto;
        double diagonal;
        
        Console.Write("Introduce el ancho: ");
        ancho = Convert.ToSingle(Console.ReadLine());
        Console.Write("Introduce el alto: ");
        alto = Convert.ToSingle(Console.ReadLine());
        
        perimetro = 2*ancho + 2*alto;
        area = ancho * alto;
        diagonal = Math.Sqrt(ancho*ancho + alto*alto);
        
        Console.WriteLine("El perímetro es: {0}", perimetro.ToString("N1"));
        Console.WriteLine("El área es: {0}", area.ToString("N1"));
        Console.WriteLine("La diagonal es {0}", diagonal.ToString("N1"));

    }
}
