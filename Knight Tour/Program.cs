using System;
using System.Collections.Generic;
using System.Text;

namespace Knight_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            ChessBoard.CreateChessBoard();
            ChessBoard.DisplayChessBoard();
            // KnightMoves.KnightTour();
            Knight_Tour__EFficient_Approach.KnightTour();
            Console.ReadLine();
        }

        

    }
}
