/* Hugo Martínez
 * Programa para calcular el área de un círculo.
 * Se pide el radio del círculo al usuario.
 * No se permite usar using System
*/

class areaCirculo

{
    static void Main()
    {
        int radio;
        
        System.Console.WriteLine("Introduce el radio del círculo en metros:");
        radio = System.Convert.ToInt32(System.Console.ReadLine());
        
        System.Console.WriteLine("El área de un círculo de radio {0}m es {1}m2", 
            radio, 3.1415*radio*radio);
    }
}
