using System;
using System.Text;
using System.Threading;

namespace Ucu.Poo.GameOfLife
{
    class Board_Printer
    {
        private bool[,] b; //variable que representa el tablero
        public bool [,] B
        {
            get {return this.b;} set {this.b = value;}
        }
        private int width; //variabe que representa el ancho del tablero
        public int Width
        {
            get {return this.width;} set {this.width = value;}
        }
        private int height; //variabe que representa altura del tablero
        public int Height
        {
            get {return this.height;} set {this.height=value;}
        }
        void Print()
        {
            while (true)
            {
                Console.Clear();
                StringBuilder s = new StringBuilder();
                for (int y = 0; y<height;y++)
                {
                    for (int x = 0; x<width; x++)
                    {
                        if(b[x,y])
                        {
                            s.Append("|X|");
                        }
                        else
                        {
                            s.Append("___");
                        }
                    }
                }
            s.Append("\n");
            Console.WriteLine(s.ToString());
    //=================================================
    //Invocar método para calcular siguiente generación
    //=================================================
            Thread.Sleep(300);
            }
        }
        public Board_Printer(bool[,] b,int width, int height)
        {
            this.B=b;
            this.Width=width;
            this.Height=height;
        }
    }
}
