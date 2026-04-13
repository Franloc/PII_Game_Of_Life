using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Threading;

namespace Ucu.Poo.GameOfLife
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inicio del programa");
            
            //Crear el board importer
            Board_Importer importador = new Board_Importer();

            //Obtener el tablero inicial
            bool[,] tablero_inicial = importador.Cargar_archivo();
            
            //Crea el tablero
            Board tablero = new Board(tablero_inicial);
            
            //Crea el printer
            Board_Printer printer = new Board_Printer(tablero_inicial,tablero.BWidth,tablero.BHeight);
            
            //Crea el motor
            MotorDeReglas motor = new MotorDeReglas();

            Juego(tablero, printer, motor);
        }
        public void Juego(Board board, Board_Printer printer, MotorDeReglas motor)
        {
            while (true)
            {
                printer.Print();
                Thread.Sleep(300);
                motor.Generacion(board);
            }
        }
    }
}
