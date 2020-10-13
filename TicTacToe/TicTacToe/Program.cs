using System;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! Welcome to TicTacToe game");
            TicTacTaoBoard board = new TicTacTaoBoard();
            board.CreateBoard();
        }

       
    }
}
