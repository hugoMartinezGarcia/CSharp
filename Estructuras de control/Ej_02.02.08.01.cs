// Escribe 6 líneas de texto, cada una formada por los números del 1 al 7.

using System;

class Ejercicio_02_02_08_01
{
    static void Main()
    {
        for (int linea=0; linea<6; linea++)
        {
            for (int numero=1; numero<=7; numero++)
            {
                Console.Write("{0} ", numero);
            }
            Console.WriteLine();
        }
    }
}
