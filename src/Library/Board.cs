using System.Collections.Generic;

namespace Ucu.Poo.GameOfLife
{
    public class Board
    {
        //Atributos
        private List<Cell> cells;
        public List<Cell> Cells
        {
            get { return this.cells;} set { this.cells = value;}
        }
        private bool[,] gameBoard;
        public bool[,] GameBoard
        {
            get {return this.gameBoard;}
        }

        //Dimensiones del board
        private int bWidth;
        public int BWidth
        {
            get {return this.bWidth;} set {this.bWidth = value;}
        }
        private int bHeigth;
        public int BHeigth
        {
            get {return this.bHeigth;} set {this.bHeigth = value;}
        }


        //Constructor
        public Board(bool[,] importedBoard)
        {
            gameBoard = importedBoard;
            BWidth = importedBoard.GetLength(0);
            BHeigth = importedBoard.GetLength(1);


            //Anade una celula //No estoy seguro si es necesario tener una lista de celulas, no me acuerdo que
            //habia que hacer con las celulas.
            for (int y = 0; y<BHeigth;y++)
            {
                for (int x = 0; x<BWidth; x++)
                {
                    if(importedBoard[x,y])
                    {
                        this.cells.Add(new Cell(true));
                    }
                    else
                    {
                        ;
                    }
                }
                
            }
        }

    }
}