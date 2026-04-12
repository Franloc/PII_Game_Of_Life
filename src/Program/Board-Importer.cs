using System;
using System.Reflection;
using System.Text;
using System.IO;

namespace Ucu.Poo.GameOfLife
{
    class Board_Importer
    {
        //Atributos
        private string url;
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
            get {return this.ContentLines;} set {this.contentLines = value;}
        }
        private bool[,] board;
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
                    board[x,y]=true;
                    }
                }
            }
            return board;
        }

        //Constructor
        public Board_Importer()
        {
            Url = "assets/board.txt";
            content = File.ReadAllText(Url);
            contentLines = content.Split('\n');
            board = new bool[contentLines.Length, contentLines[0].Length];
        }
    }
}