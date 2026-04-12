using System;

namespace Ucu.Poo.GameOfLife
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inicio del programa");

            //Crear el board importer
            Board_Importer importador = new Board_Importer();
            
            //Crea el tablero
            Board tablero = new Board(importador.Cargar_archivo());



        }
    }
}
