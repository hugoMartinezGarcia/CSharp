/* Se almacenan los días de la semana en un array. Muestra todos los días en 
 * pantalla separados por un espacio. Después pide al usuario un número de día
 * y muestra su nombre
 * Por Hugo Martínez.
*/

using System;

class Ejercicio_62
{
    static void Main()
    {
        string[] dias = {"Lunes", "Martes", "Miércoles", "Jueves", "Viernes", 
            "Sábado", "Domingo"};
        int diaSemana;
        
        for (int i = 0; i < dias.Length; i++)
        {
            Console.Write(dias[i] + " ");
        }
        
        Console.WriteLine();
        Console.Write("Introduce un número de día de la semana: ");
        diaSemana = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine(dias[diaSemana - 1]);
    }
}
