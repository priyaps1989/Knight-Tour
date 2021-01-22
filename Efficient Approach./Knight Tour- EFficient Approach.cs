using System;
using System.Collections.Generic;
using System.Text;

namespace Knight_Tour
{
    class Knight_Tour__EFficient_Approach:ChessBoard

    {
        private static readonly int[,] EligibleMoves = { { 1, 2 }, { -2, 1 }, { -2, -1 }, { -1, 2 }, { -1, -2 }, { 2, 1 }, { 2, -1 }, { 1, -2 }, };
        public const int PossibleMovesFromPoint = 8;

        static Boolean ValidMovesofKnight(int i, int j, int[,] chessboard)
        {
            if (i >= 0 && i < BoardSize && j >= 0 && j < BoardSize)
            {
                if (chessboard[i, j] == UnoccupiedGrid)
                    return true;
            }
            return false;
        }

        static bool BeginTour(int HorizontalMove, int VerticalMove, int BlockCount, int[,] chessboard, int[,] EligibleMoves)
        {

            if (BlockCount == BoardSize * BoardSize)
                return true;

            for (int Counter = 0; Counter < PossibleMovesFromPoint; Counter++)
            {
                int NextHorizontalMove = HorizontalMove + EligibleMoves[Counter, 0];
                int NextVerticalMove = VerticalMove + EligibleMoves[Counter, 1];
                if (ValidMovesofKnight(NextHorizontalMove, NextVerticalMove, chessboard))
                {
                    chessboard[NextHorizontalMove, NextVerticalMove] = BlockCount;
                    if (BeginTour(NextHorizontalMove, NextVerticalMove, BlockCount + 1, chessboard, EligibleMoves))
                        return true;
                    else
                        //not a feasible solution and so backtrack
                        chessboard[NextHorizontalMove, NextVerticalMove] = UnoccupiedGrid;
                }
            }

            return false;
        }

        public static void KnightTour()
        {

            Console.WriteLine("\tA Knight is placed at the lower left corner of the Chess Board ");
            Console.WriteLine("\t--------------------------------------------------------------");
            chessboard[BoardSize - 1, 0] = 0;
            DisplayChessBoard();
            Console.WriteLine("\tA Knight's tour from the lower left corner of the Chess Board covering all squares once ");
            Console.WriteLine("\t----------------------------------------------------------------------------------------");
            BeginTour(BoardSize - 1, 0, 1, chessboard, EligibleMoves);
            DisplayChessBoard();
           
        }

       
       

    }

   
}

