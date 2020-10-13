using System;
namespace TicTacToe
{
    class TicTacTaoBoard
    {
        
        public char[] CreateBoard()
        {
            char[] board = new char[10];
            for (int i = 0; i < board.Length; i++)
            {
                board[i] = ' ';
            }
            return board;
        }
    }
}
