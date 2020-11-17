/* Pide un símbolo y responde si es dígito, operador, signo de puntuación u 
 * otro símbolo.
 * Usando "if" con booleanos y después "switch"
 * Hugo Martínez
 */

using System;

class Ejercicio_55
{
    static void Main()
    {
        char simbolo;
        bool esCifra, esSigno, esOperador;
        
        Console.WriteLine("Introduce un símbolo y te diré de qué tipo es:");
        simbolo = Convert.ToChar(Console.ReadLine());
        
        esCifra = (simbolo >= '0') && (simbolo <= '9');
        esSigno = (simbolo == '+') || (simbolo == '-') || 
            (simbolo == '*') || (simbolo == '/') || (simbolo == '%');
        esOperador = (simbolo == '.') || (simbolo == ',') || (simbolo == ';') || 
            (simbolo == ':');
        // Versión usando "if"
        if (esCifra)
        {
            Console.WriteLine("Es una cifra.");
        }
        else if (esOperador)
        {
            Console.WriteLine("Es un operador.");
        }
        else if (esSigno)
        {
            Console.WriteLine("Es un signo de puntuación.");
        }
        else
        {
            Console.WriteLine("Es otro símbolo.");
        }
        
        // Versión usando "switch"
        switch (simbolo)
        {
            case '0':
            case '1':
            case '2':
            case '3':
            case '4':
            case '5':
            case '6':
            case '7':
            case '8':
            case '9': Console.WriteLine("Es una cifra."); break;
            case '+':
            case '-':
            case '*':
            case '/':
            case '%': Console.WriteLine("Es un operador."); break;
            case '.':
            case ',':
            case ';':
            case ':': Console.WriteLine("Es un signo de puntuación."); break;
            default: Console.WriteLine("Es otro símbolo."); break;
        }
    }
}
