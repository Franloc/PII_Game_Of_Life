using System;
using System.IO;

namespace Ucu.Poo.GameOfLife
{
    public class Board_Importer
    {
        //Esta clase se encarga de importar el board inicial del cual parte la simulacion


        //Atributos
        private string url; //url para acceder al asset
        public string Url
        {
            get { return this.url;} set { this.url = value;}
        }
        private string content;
        public string Content
        {
            get {return this.content;} set {this.content = value;}
        }
        private string[] contentLines;
        public string[] ContentLines
        {
            get {return this.contentLines;} set {this.contentLines = value;}
        }
        private bool[,] board; //Representa el tablero
        public bool[,] Board
        {
            get {return this.board;} set {this.board = value;}
        }
        
        //Metodos

        //Carga el archivo del tablero
        public bool[,] Cargar_archivo()
        {
            for (int  y=0; y<contentLines.Length;y++)
            {
                for (int x=0; x<contentLines[y].Length; x++)
                {
                if(contentLines[y][x]=='1')
                    {
                    board[y,x]=true;
                    }
                }
            }
            return board;
        }

        //Constructor
        public Board_Importer()
        {
            Url = "../../../../../assets/board.txt";
            content = File.ReadAllText(Url);
            contentLines = content.Split('\n');
            board = new bool[contentLines.Length, contentLines[0].Length];
        }
    }
}
