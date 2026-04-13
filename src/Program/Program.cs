using System;
using System.Threading;

namespace Ucu.Poo.GameOfLife
{
    class Program
    {
        // Clase Program donde se corre el juego
        
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
                printer.Print(); //Imprime el tablero
                tablero.GameBoard = motor.Generacion(tablero); //Actualiza el board a la nueva generacion
                printer.B = tablero.GameBoard; //Actualiza el board que debe imprimir el printer
            }
        }
    }
}
