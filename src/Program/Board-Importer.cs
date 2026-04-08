using System;
using System.Reflection;
using System.IO;

namespace Ucu.Poo.GameOfLife
{
    class Board_Importer
    {
        string url;
        string content;
        string[] contentLines;
        bool[,] board;
        public Board_Importer()
        {
            url = "assets/board.txt";
            content = File.ReadAllText(url);
            contentLines = content.Split('\n');
            board = new bool[contentLines.Length, contentLines[0].Length];
        }
        void Cargar_archivo()
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
        }
    }
}