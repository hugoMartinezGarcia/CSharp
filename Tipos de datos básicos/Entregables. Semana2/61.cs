/* Calcula el número e utilizando la expresión e = 1 + 1/1 +1/(1·2) 1 1/(1·2·3)...
 * El usuario indicará el número de sumandos y se mostrará el cálculo y la 
 * diferencia con respecto a emplear un sumando menos
 * Hugo Martínez
 */
 
using System;

class Ejercicio_61
{
    static void Main()
    {
        string sumandosTexto;
        int sumandos;
        double denominador, e;
        bool continuar;
        
        do 
        {
            Console.Write("Sumandos? ");
            sumandosTexto = Console.ReadLine();
            
            continuar = sumandosTexto != "" && sumandosTexto != "0";
            
            if (continuar)
            { 
                sumandos = Convert.ToInt32(sumandosTexto);
                denominador = 1;
                e = 1;
                for (int i=2; i<=sumandos; i++)
                {
                    denominador *= (i-1); 
                    e += 1 / denominador;
                }
                Console.WriteLine("e vale aproximadamente {0} " + 
                    "(diferencia con {1} sumandos: {2})", 
                        e, sumandos-1, 1/denominador);
            }
        }
        while (continuar);
        
        Console.WriteLine("¡Hasta otra!");
    }
}
