/* Programa para almacenar una colección de juegos. Muestra un menú hasta que 
 * se pulsa "X" para salir. De las diferentes opciones a elegir solo funciona 
 * la primera. El resto se encuentran sin implementar. Se almacenará solo la 
 * información del último juego guardado, aunque mostrará un contador con el 
 * total de juegos almacenados.
 * Por Hugo Martínez García.
*/
using System;

class coleccion_juegos 
{
    enum opciones {ANYADIR = 1, BUSCAR, MODIFICAR, BORRAR}
    
    static void Main() 
    {
        const string SALIR = "X";
        string opcion;
        bool salir;
        int cantidadJuegos = 0;
        string nombre, plataforma, ubicacion;
        float valoracion;
        ushort anyoPublicacion;
        int opcionNumero = 0;
        bool esNumero = false;
        
        do
        {
            Console.WriteLine();
            Console.WriteLine((int)opciones.ANYADIR + ". Añadir datos de un " +
                "juego.");
            Console.WriteLine((int)opciones.BUSCAR + ". Buscar entre los " + 
                "juegos existentes.");
            Console.WriteLine((int)opciones.MODIFICAR + ". Modificar los " + 
                "datos de un juego.");
            Console.WriteLine((int)opciones.BORRAR + ". Borrar un juego.");
            Console.WriteLine(SALIR + ". Salir.");
            Console.WriteLine();
            
            if (cantidadJuegos > 0)
            {
                Console.WriteLine("Juegos disponibles: " + cantidadJuegos);
            } 
            
        /* Implemento este bloque "do.. while" para interceptar posibles errores 
         * en la introducción de datos por parte del usuario y que se repita 
         * hasta que sea correcto (escritura de letras, etc.)
         */
            do 
            {
                opcion = Console.ReadLine();
                salir = opcion == "x" || opcion == "X";
               
                if (!salir)
                {
                    try
                    {
                        opcionNumero = Convert.ToInt32(opcion);
                        esNumero = true;
                    } 
                    catch (Exception) 
                    {
                        Console.WriteLine("Opción incorrecta");
                        esNumero = false;
                    }
                }
            } 
            while (!esNumero && !salir);
            
            switch (opcionNumero)
            { 
                case (int)opciones.ANYADIR: 
                    Console.Clear();
                    Console.WriteLine("El programa está en fase de pruebas. " + 
                        "No se podrán guardar los datos.");

                    Console.WriteLine();
                    Console.Write("Nombre del juego: ");
                    nombre = Console.ReadLine();
                    Console.Write("Plataforma: ");
                    plataforma = Console.ReadLine();
                    Console.Write("Año publicación: ");
                    anyoPublicacion = Convert.ToUInt16(Console.ReadLine());
                    Console.Write("Ubicación: ");
                    ubicacion = Console.ReadLine();
                    Console.Write("Valoración personal: ");
                    valoracion = Convert.ToSingle(Console.ReadLine());
                        
                    cantidadJuegos++;
                    
                    break;
                    
                case (int)opciones.BORRAR:
                case (int)opciones.BUSCAR:
                case (int)opciones.MODIFICAR: Console.WriteLine("Opción " + 
                    "todavía no implementada"); 
                    break;
                default: 
                    if (!salir)
                        Console.WriteLine("Opción incorrecta"); break;
            }
        } 
        while (!salir);
        
        Console.WriteLine("Hasta luego!");
    }
}
