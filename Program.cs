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
            printBoard(myBoard);

            Console.ReadLine();
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
                        Console.WriteLine("X");
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
