// Pide una distancia en metros y el tiempo necesario para recorrerla.
// Muestra la velocidad en m/s, Km/h y millas/h.

using System;
class Ejercicio_03_02_03_02
{
 static void Main()
    {
        float distancia, horas, minutos, segundos, tiempo, velocidad;
      
        Console.Write("Introduce la distancia en metros: ");
        distancia = Convert.ToSingle(Console.ReadLine());

        Console.Write("Horas?");
        horas = Convert.ToSingle(Console.ReadLine());
        Console.Write("Minutos?");
        minutos = Convert.ToSingle(Console.ReadLine());
        Console.Write("Segundos?");
        segundos = Convert.ToSingle(Console.ReadLine());
        
        tiempo = horas * 3600 + minutos * 60 + segundos;
        velocidad = distancia / tiempo;
        
        Console.WriteLine("Velocidad en metros por segundo: {0} m/s", velocidad);
        Console.WriteLine("Velocidad en kilómetros por hora: {0} Km/h", 
            velocidad * 3600 / 1000 );
        Console.WriteLine("Velocidad en millas por hora: {0} millas/h",
            velocidad * 3600 / 1609);
    }
}
