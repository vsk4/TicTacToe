﻿using System;
namespace TicTacToeGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to TicTacToe Game");
            TicTacToeGame game = new TicTacToeGame();
            char[] board = game.createBoard();
            game.choosePlayerLetter();
            game.showBoard(board);
            game.userMove(board);
            Console.WriteLine("dfasdf");
        }
    }
}