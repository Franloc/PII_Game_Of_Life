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
            
            // Crea el tablero a modificar
            Board tablero = new Board(importador.Cargar_archivo());
            
            //Crea el printer
            Board_Printer printer = new Board_Printer(tablero_inicial,tablero.BWidth,tablero.BHeight);
            
            //Crea el motor
            MotorDeReglas motor = new MotorDeReglas();
        }
        public void Juego(Board tablero, Board_Printer printer, MotorDeReglas motor)
        {
            while (true)
            {
                printer.Print();
                Thread.Sleep(300);
                motor.Generacion(tablero);
            }
        }
    }
}
