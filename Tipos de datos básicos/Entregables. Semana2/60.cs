/* Pide números reales de doble precisión al usuario y muestra su máximo, mínimo,
 * suma y media después de cada paso. Se terminará cuando se introduzca "fin"
 * Hugo Martínez
 */

using System;

class Ejercicio_60
{
    static void Main()
    {
        string datoTexto;
        double dato, suma = 0, media, maximo = 0, minimo = 0;
        int numDatos = 1;
        bool continuar;
        
        do
        {
            Console.Write("Dato: ");
            datoTexto = Console.ReadLine();
            
            continuar = datoTexto != "Fin" && datoTexto != "fin" && 
                datoTexto != "FIN" && datoTexto != "";
            
            if (continuar)
            {
                dato = Convert.ToDouble(datoTexto);
                suma += dato;
                media = suma / numDatos;
                
                // En la primera pasada máximo y mínimo toman el valor del dato.
                if (numDatos == 1)
                {
                    maximo = minimo = dato;
                }
                else
                {
                    maximo = dato > maximo ? dato: maximo;
                    minimo = dato < minimo ? dato: minimo;
                }
                
                Console.WriteLine("Máximo = {0}. Mínimo = {1}. Suma = {2}. " + 
                    "Media = {3}.", maximo, minimo, suma, media);
                    
                numDatos++;
            }
        }
        while (continuar);
        
        Console.WriteLine("¡Hasta luego!");
    }
}
