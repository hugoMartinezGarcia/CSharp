/* Crea un array de doble precisión con espacio para 1000 datos. Muestra un 
 * menú que permite Añadir un dato al final, Insertar un dato en una cierta 
 * posición, Borrar un dato, Ver los datos, Ver los datos en orden inverso, 
 * Mostrar el máximo, Mostrar el mínimo, Buscar un cierto dato y salir.
 * Por Hugo Martínez.
*/

using System;

class Ejercicio_66
{
    enum opciones {SALIR, ANYADIR, INSERTAR_POSICION, BORRAR, VER, VER_INVERSO, 
        MAXIMO, MINIMO, BUSCAR};
    
    static void Main()
    {
        const int TAMANO = 1000;
        double[] numeros = new double[TAMANO];
        byte opcion;
        double datoABuscar, maximo, minimo;
        bool encontrado;
        bool continuar = true;
        int cantidad = 0, posicionInsertar, posicionBorrar;
        
        do
        {
            Console.WriteLine();
            Console.WriteLine((byte)opciones.ANYADIR + ". Añadir dato al final.");
            Console.WriteLine((byte)opciones.INSERTAR_POSICION + ". Insertar " + 
                "dato en posición.");
            Console.WriteLine((byte)opciones.BORRAR + ". Borrar un dato.");
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
                case (byte)opciones.ANYADIR:
                    if (cantidad < TAMANO) 
                    {
                        Console.Write("Introduce el dato que quieres añadir: ");
                        numeros[cantidad] = Convert.ToDouble(Console.ReadLine());
                        cantidad++;
                    }
                    else
                        Console.WriteLine("No se pueden introducir más datos.");
                    
                    break;
                    
                case (byte)opciones.INSERTAR_POSICION:
                    if (cantidad < TAMANO) 
                    {
                        Console.Write("¿En qué posición deseas añadir el dato?: ");
                        posicionInsertar = Convert.ToInt32(Console.ReadLine());
                        if (posicionInsertar > cantidad || posicionInsertar <= 0)
                            Console.WriteLine("Posición incorrecta.");
                        else
                        {
                            for (int i = cantidad; i > posicionInsertar-1; i--)
                                numeros[i] = numeros[i-1];
                        
                            Console.Write("Introduce el dato que quieres añadir: ");
                            numeros[posicionInsertar-1] = 
                                Convert.ToDouble(Console.ReadLine());
                            cantidad++;
                        }
                    }
                    else
                        Console.WriteLine("No se pueden introducir más datos.");
                    
                    break;
                
                case (byte)opciones.BORRAR:
                
                    Console.Write("¿En qué posición deseas borrar un dato?: ");
                    posicionBorrar = Convert.ToInt32(Console.ReadLine());
                    
                    if (posicionBorrar > cantidad || posicionBorrar <= 0)
                        Console.WriteLine("Posición incorrecta!");
                    else
                    {
                        for (int i = posicionBorrar-1; i < cantidad; i++)
                            numeros[i] = numeros[i+1];

                        cantidad--;
                    }
                    break;
                    
                case (byte)opciones.VER:
                    Console.Write("Datos del array: ");
                    for (int i = 0; i < cantidad; i++)
                    {
                        Console.Write(numeros[i] + " ");
                    }
                    Console.WriteLine();
                    break;

                case (byte)opciones.VER_INVERSO:
                    Console.Write("Datos del array en orden inverso: ");
                    for (int i = cantidad - 1; i >= 0; i--)
                    {
                        Console.Write(numeros[i] + " ");
                    }
                    Console.WriteLine();
                    break;
                
                case (byte)opciones.MAXIMO:
                    maximo = numeros[0];
                    for (int i = 1; i < cantidad; i++)
                    {
                        if (numeros[i] > maximo)
                            maximo = numeros[i];
                    }
                    Console.WriteLine("El máximo es: " + maximo);
                    break;
                    
                case (byte)opciones.MINIMO:
                    minimo = numeros[0];
                    for (int i = 1; i < cantidad; i++)
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
                    for (int i = 0; i < cantidad; i++)
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
