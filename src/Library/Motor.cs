namespace Ucu.Poo.GameOfLife
{
    public class MotorDeReglas
    {     
        public bool[,] Generacion(Board boardObj)
        {
            bool[,] gameBoard = boardObj.GameBoard;
            int height = gameBoard.GetLength(0); // filas
            int width = gameBoard.GetLength(1);  // columnas
            bool[,] cloneboard = new bool[height, width];
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    int aliveNeighbors = 0;
                    for (int i = y - 1; i <= y + 1; i++)
                    {
                        for (int j = x - 1; j <= x + 1; j++)
                        {
                            // Validación de bordes
                            if (i >= 0 && i < height && j >= 0 && j < width)
                            {
                                if (gameBoard[i, j])
                                {
                                aliveNeighbors++;
                                }
                            }
                        }
                    }
                    // Sacar la celda actual
                if (gameBoard[y, x])
                {
                    aliveNeighbors--;
                }
                // Reglas del juego
                if (gameBoard[y, x] && aliveNeighbors < 2)
                    cloneboard[y, x] = false;
                else if (gameBoard[y, x] && aliveNeighbors > 3)
                    cloneboard[y, x] = false;
                else if (!gameBoard[y, x] && aliveNeighbors == 3)
                    cloneboard[y, x] = true;
                else
                    cloneboard[y, x] = gameBoard[y, x];
                }
            }

        gameBoard = cloneboard;
        return gameBoard;
        }  
    } 
} 
