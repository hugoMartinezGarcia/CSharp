/* Crea un array de doble precisión con espacio para 10 datos. Pide los datos
 * al usuario y después muestra un menú que permite Ver los datos, ver los datos
 * en orden inverso, mostrar el máximo, mostrar el mínimo, buscar un cierto 
 * dato y salir.
 * Por Hugo Martínez.
*/

using System;

class Ejercicio_65
{
    enum opciones {SALIR, VER, VER_INVERSO, MAXIMO, MINIMO, BUSCAR};
    
    static void Main()
    {
        const int TAMANO = 10;
        double[] numeros = new double[TAMANO];
        byte opcion;
        double datoABuscar, maximo, minimo;
        bool encontrado;
        bool continuar = true;
        
        for (int i = 0; i < TAMANO; i++)
        {
            Console.Write("Introduce el {0}º número: ", i+1);
            numeros[i] = Convert.ToDouble(Console.ReadLine());
        }
        
        do
        {
            Console.WriteLine();
            Console.WriteLine((byte)opciones.VER + ". Ver datos originales.");
            Console.WriteLine((byte)opciones.VER_INVERSO + ". Ver datos en " + 
                "orden inverso.");
            Console.WriteLine((byte)opciones.MAXIMO + ". Mostrar el máximo.");
            Console.WriteLine((byte)opciones.MINIMO + ". Mostrar el mínimo.");
            Console.WriteLine((byte)opciones.BUSCAR + ". Buscar un dato.");
            Console.WriteLine((byte)opciones.SALIR + ". Salir.");
            
            opcion = Convert.ToByte(Console.ReadLine());
            
            switch (opcion)
            {
                case (byte)opciones.VER:
                    Console.Write("Datos del array: ");
                    for (int i = 0; i < TAMANO; i++)
                    {
                        Console.Write(numeros[i] + " ");
                    }
                    Console.WriteLine();
                    break;

                case (byte)opciones.VER_INVERSO:
                    Console.Write("Datos del array en orden inverso: ");
                    for (int i = TAMANO - 1; i >= 0; i--)
                    {
                        Console.Write(numeros[i] + " ");
                    }
                    Console.WriteLine();
                    break;
                
                case (byte)opciones.MAXIMO:
                    maximo = numeros[0];
                    for (int i = 1; i < TAMANO; i++)
                    {
                        if (numeros[i] > maximo)
                            maximo = numeros[i];
                    }
                    Console.WriteLine("El máximo es: " + maximo);
                    break;
                    
                case (byte)opciones.MINIMO:
                    minimo = numeros[0];
                    for (int i = 1; i < TAMANO; i++)
                    {
                        if (numeros[i] < minimo)
                            minimo = numeros[i];
                    }
                    Console.WriteLine("El mínimo es: " + minimo);
                    break;
                    
                case (byte)opciones.BUSCAR:
                    encontrado = false;
                    Console.WriteLine("Introduce el dato a buscar:");
                    datoABuscar = Convert.ToDouble(Console.ReadLine());
                    for (int i = 1; i < TAMANO; i++)
                    {
                        if (numeros[i] == datoABuscar)
                            encontrado = true;
                    }
                    if (encontrado)
                        Console.WriteLine(datoABuscar + " se encuentra en " + 
                            "el array.");
                    else
                        Console.WriteLine(datoABuscar + " NO se encuentra en " +
                            "el array.");
                    break;
                    
                case (byte)opciones.SALIR:
                    continuar = false;
                    break;
                    
                default: Console.WriteLine("Opción incorrecta!");
                    break;
            }
        }
        while(continuar);
        
        Console.WriteLine("Hasta luego!");
    }
}
