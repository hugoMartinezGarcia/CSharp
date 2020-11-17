/* Pide al usuario su edad, año de nacimiento, estatura en cm, población de su 
 * ciudad y dinero ahorrado. Optimizando el tipo de datos.
 * Hugo Martínez
*/

using System;

class Ejercicio_48
{
    static void Main()
    {
        byte edad;
        ushort estatura, anyoNacimiento;
        uint poblacion, dinero;
        
        Console.Write("Introduce tu edad: ");
        edad = Convert.ToByte(Console.ReadLine());
        Console.Write("Introduce tu estatura en cm: ");
        estatura = Convert.ToUInt16(Console.ReadLine());
        Console.Write("Introduce tu año de nacimiento: ");
        anyoNacimiento = Convert.ToUInt16(Console.ReadLine());
        Console.Write("Introduce la población de tu ciudad: ");
        poblacion = Convert.ToUInt32(Console.ReadLine());
        Console.Write("Introduce tu dinero ahorrado: ");
        dinero = Convert.ToUInt32(Console.ReadLine());
        
        Console.WriteLine("Tienes {0} años. Mides {1}cm. Naciste en {2}. " + 
            "En tu ciudad hay {3} habitantes. Tienes {4}euros en el banco", 
                edad, estatura, anyoNacimiento, poblacion, dinero);
        
    }
}
