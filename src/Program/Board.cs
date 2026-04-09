using System;
using System.Collections.Generic;
using System.Threading;

public class Board
{
    private List<Cell> cells = new List<Cell>();
    public List<Cell> Cells
    {
        get { return this.cells;} set { this.cells = value;}
    }

    public Board(bool[,] bools)
    {
        int height = bools.Length;
        int width = bools.Length;
        for (int y = 0; y<height;y++)
        {
            for (int x = 0; x<width; x++)
            {
                if(bools[x,y])
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