using System;
// Espacio de nombres
namespace CS5
{
   class Program
   {
        static void Main(string[] args)
        {
            // Unidad 1: Estructuras de control II
            // Unidad 2: Funciones II
            // Sesion 12: Instruccion while 30092026
            // Sintaxis: while
            // inicializacion;
            // while(expresion)
            // {
            //       Bloque de instrucciones
            //       iterador;
            // }
            // Iterar: repetir
            // Ejemplo 1: Ciclo ascendente (rango: 1-3)
            int m = 1; // Inicializacion
            while(m <= 3)
            {
                // Bloque de instrucciones
                m += 1;
                Console.WriteLine($"m: {m}");
                m += 1;
            }
        }
   }
}
