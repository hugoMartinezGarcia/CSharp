// Escribe 4 líneas de texto formadas por los números del 1 al 5

using System;

class Ejercicio_02_02_06_01
{
    static void Main()
    {
        int fila, columna;
        
        for (fila = 1; fila <= 4; fila++)
        {
            for (columna = 1; columna <= 5; columna++)
            {
                Console.Write(columna);
            }
            Console.WriteLine();
        }
    }
}
