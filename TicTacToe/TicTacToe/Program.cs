using System;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            char[] board = tictactoeBoard();
        }

        private static char[] tictactoeBoard()
        {
            char[] board = new char[10];
            for (int i =0; i< board.Length; i++)
            {
                board[i] = ' ';
            }
            return board;
        }
    }
}
