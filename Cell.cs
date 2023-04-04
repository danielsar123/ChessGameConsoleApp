using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBoardModel
{
    public class Cell
    {
        // represents position of cell on chessboard, ranges from #1-8
        public int RowNumber { get; set; }
        public int ColumnNumber { get; set; }

        // true if cell has chess piece on it, false if empty
        public bool CurrentlyOccupied { get; set; }

        // determines if chess piece can legally move to cell 
        public bool LegalNextMove { get; set; }

        // constructor takes in two integers for row and column 
        public Cell(int x, int y)
        {
            RowNumber = x;
            ColumnNumber = y;
        }

    }
}
