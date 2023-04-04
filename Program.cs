using ChessBoardModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGameConsoleApp
{
    public class Program
    {
        //create new Static instance, no other instance can be made while program is running 
        static Board myBoard = new Board(8);
        static void Main(string[] args)
        { 
            // show empty chess Board
            printBoard(myBoard);

            // ask user for x and y coordinate to place piece
            Cell currentCell = setCurrentCell();

            // set the Current cell to occupied
            currentCell.CurrentlyOccupied = true;

            // calculate all legal moves for the piece, hardcoding "Knight" for now, to be resolved later 
            myBoard.MarkNextLegalMoves(currentCell, "Knight");

            // print Board. Use X for occupied square, + for legal move, . for empty square
            printBoard(myBoard);


            // wait for user input after board is printed
            Console.ReadLine();
        }

        private static Cell setCurrentCell()
        {
            // get x and y coordinate from user
            Console.WriteLine("Enter current row number");
            int currentRow = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter current column number");
            int currentColumn = int.Parse(Console.ReadLine());

            // return the current Cell
            return myBoard.theGrid[currentRow, currentColumn];
        }

        private static void printBoard(Board myBoard)
        { 
            // first loop each row
            for (int i = 0; i < myBoard.Size; i++)
            {
                //second loop each column
                for (int j = 0; j < myBoard.Size; j++)
                {
                    Cell c = myBoard.theGrid[i, j];

                    if (c.CurrentlyOccupied == true)
                    {
                        Console.Write("X");
                    }
                    else if (c.LegalNextMove == true)
                    {
                        Console.Write("+");

                    }
                    else
                    {
                        Console.Write(".");
                    }

                }
                Console.WriteLine();
            }
            Console.WriteLine("===============================");

            
        }
    }
}
