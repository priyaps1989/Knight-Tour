using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Knight_Tour
{
    public class KnightMoves: ChessBoard
    {
         //since we cannot have const for arrays they are objects and created at run time
        private static readonly int[,] EligibleMoves = { { 1, 2 }, { -2, 1 }, { -2, -1 }, { -1, 2 }, { -1, -2 }, { 2, 1 }, { 2, -1 }, { 1, -2 }, };
        public const int PossibleMovesFromPoint = 8;
        public static Boolean ValidMovesofKnight(int i, int j)
        {
            //Console.WriteLine("Hello4 ");
            if (i >= 0 && i < BoardSize && j >= 0 && j < BoardSize)
                {
                    if (chessboard[i,j] == 'X' || chessboard[i, j]=='O' )
                        return true;
                }
                return false;
        }

        public static Boolean BeginTour(int HorizontalMove, int VerticalMove, int BlockCount)
        {
            if (BlockCount == BoardSize * BoardSize)
                return true;

            for (int counter = 0; counter < PossibleMovesFromPoint; counter++)
            {
                int NextHorizontalMove = HorizontalMove + EligibleMoves[counter, 0];
                int NextVerticalMove = VerticalMove + EligibleMoves[counter, 1];
               

                if (ValidMovesofKnight(NextHorizontalMove, NextVerticalMove))
                {
                    
                    chessboard[NextHorizontalMove, NextVerticalMove] = '$';
                    DisplayChessBoard();//if each move is to be displayed
                    System.Threading.Thread.Sleep(1000);//Delay the movement of the knight for displaying
                    if (BeginTour(NextHorizontalMove, NextVerticalMove, BlockCount + 1))
                        return true;
                }
            }

            return false;
        }




        public static void KnightTour()
        {
            Console.WriteLine("\tA Knight is placed at the lower left corner of the Chess Board ");
            Console.WriteLine("\t--------------------------------------------------------------");
            chessboard[BoardSize-1, 0] = '$';
            DisplayChessBoard();
            Console.WriteLine("\tA Knight's tour from the lower left corner of the Chess Board covering all squares once ");
            Console.WriteLine("\t----------------------------------------------------------------------------------------");

            BeginTour(BoardSize - 1, 0,1);
            //DisplayChessBoard(); // if only final grid is to be displayed

        }

    }


    
}
