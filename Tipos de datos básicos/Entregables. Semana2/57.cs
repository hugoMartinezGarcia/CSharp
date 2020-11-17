/* Pide dos números al usuario y un operador. Entonces devuelve el resultado 
 * de esa operación. Una versión con "if" y otra con "switch"
 * Hugo Martínez
 */

using System;

class Ejercicio_57
{
    static void Main()
    {
        long numero1, numero2;
        char operacion;
        
        Console.Write("Introduce el primer número: ");
        numero1 = Convert.ToInt64(Console.ReadLine());
        Console.Write("Introduce el segundo número: ");
        numero2 = Convert.ToInt64(Console.ReadLine());
        Console.Write("Introduce el símbolo del operador: ");
        operacion = Convert.ToChar(Console.ReadLine());
        
        // Versión con "if"
        Console.WriteLine();
        if (operacion == '+')
        {
            Console.WriteLine("{0} {1} {2} = {3}", 
                numero1, operacion, numero2, numero1+numero2);
        }
        else if (operacion == '-')
        {
            Console.WriteLine("{0} {1} {2} = {3}", 
                numero1, operacion, numero2, numero1-numero2);
        }
        else if ((operacion == '*') || (operacion == '·')) 
        {
            Console.WriteLine("{0} {1} {2} = {3}", 
                numero1, operacion, numero2, numero1*numero2);
        }
        else if (operacion == '/')
        {
            Console.WriteLine("{0} {1} {2} = {3}", 
                numero1, operacion, numero2, numero1/numero2);
        }
        else
        {
            Console.WriteLine("El operador introducido no es válido.");
        }
        
        // Versión con "switch"
        switch (operacion)
        {
            case '+': Console.WriteLine("{0} {1} {2} = {3}", 
                        numero1, operacion, numero2, numero1+numero2);
                        break;
            case '-': Console.WriteLine("{0} {1} {2} = {3}", 
                        numero1, operacion, numero2, numero1-numero2);
                        break;
            case '*': 
            case '·': Console.WriteLine("{0} {1} {2} = {3}", 
                        numero1, operacion, numero2, numero1*numero2);
                        break;
            case '/': Console.WriteLine("{0} {1} {2} = {3}", 
                        numero1, operacion, numero2, numero1/numero2);
                        break;
            default: Console.WriteLine("El operador introducido no es válido.");
                        break;
        }
        
        
        
    }
}
