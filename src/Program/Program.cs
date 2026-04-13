using System;
using System.Threading;

namespace Ucu.Poo.GameOfLife
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //Inicio
            Console.Clear();
            Console.WriteLine("Inicio del programa");

            
            //Crear el board importer
            Board_Importer importador = new Board_Importer();
            
            //Crea el tablero
            Board tablero = new Board(importador.Cargar_archivo());
            
            //Crea el printer
            Board_Printer printer = new Board_Printer(tablero.GameBoard,tablero.BWidth,tablero.BHeight);
            
            //Crea el motor
            MotorDeReglas motor = new MotorDeReglas();


            //Delay antes de empezar a simular
            Thread.Sleep(2000);
            
            //Loop de generacion
            while (true)
            {
                Console.Clear();
                printer.Print();
                tablero.GameBoard = motor.Generacion(tablero);
                printer.B = tablero.GameBoard;
            }
        }
    }
}
