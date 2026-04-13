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
            
            //Crea el tablero
            Board tablero = new Board(importador.Cargar_archivo());
            
            //Crea el printer
            Board_Printer printer = new Board_Printer(tablero.GameBoard,tablero.BWidth,tablero.BHeight);
            
            //Crea el motor
            MotorDeReglas motor = new MotorDeReglas();

            //nfsjnwkj
            while (true)
            {
                printer.Print();
                tablero.GameBoard = motor.Generacion(tablero);
            }
        }
    }
}
