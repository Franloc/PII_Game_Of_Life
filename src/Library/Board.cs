namespace Ucu.Poo.GameOfLife
{
    public class Board
    {
        // Esta clase se encarga de almacenar la informacion del tablero en el que se lleva a cabo la simulacion


        // Atributos
        private bool[,] gameBoard; // Representa el tablero
        public bool[,] GameBoard
        {
            get {return this.gameBoard;} set {this.gameBoard = value;}
        }

        // Dimensiones del board
        private int bWidth;
        public int BWidth
        {
            get {return this.bWidth;} set {this.bWidth = value;}
        }
        private int bHeight;
        public int BHeight
        {
            get {return this.bHeight;} set {this.bHeight = value;}
        }
        
        // Constructor
        public Board(bool[,] importedBoard)
        {
            gameBoard = importedBoard;
            BWidth = importedBoard.GetLength(1);
            BHeight = importedBoard.GetLength(0);
        }

    }
}
