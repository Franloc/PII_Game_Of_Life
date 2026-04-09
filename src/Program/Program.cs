using System;

namespace Ucu.Poo.GameOfLife
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");  
            Board_Importer importador = new Board_Importer();
            Board tablero = new Board(importador.Cargar_archivo());



        }
    }
}
