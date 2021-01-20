using System;
using System.Security.Cryptography.X509Certificates;

namespace Knight_Tour
{
    public class ChessBoard
    { 
        public const int BoardSize = 8;
        public const char UnoccupiedGridWhite = 'X';
        public const char UnoccupiedGridBlack = 'O';
        public static char [,] chessboard = new char[BoardSize, BoardSize];
        
        public static void CreateChessBoard()
        {

            for (int i = 0; i < BoardSize; i++)
            {
                for (int j = 0; j < BoardSize; j++)
                {


                    chessboard[i, j] = ((i + j) % 2 == 0) ? chessboard[i, j] = UnoccupiedGridWhite : chessboard[i, j] = UnoccupiedGridBlack;

                }
            }
            Console.WriteLine("\tA Blank Chess Board ");
            Console.WriteLine("\t-------------------");
        }
        public static void DisplayChessBoard()
        {
            
            for (int i = 0; i < BoardSize; i++)
            {
                Console.Write('\t');
                for (int j = 0; j < BoardSize; j++)
                {
                    Console.Write(" ");
                    Console.Write(chessboard[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        
    }
}
