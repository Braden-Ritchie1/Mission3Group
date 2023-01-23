using System;
using System.Collections.Generic;
using System.Text;

namespace Mission3Group
{
    class Driver
    {
        public void Board()
        {
            Console.WriteLine("Let's Play Tic-Tac-Toe!");

            int[] board = new int[9];
            board[0] = 1;
            board[1] = 0;
            board[2] = 1;
            board[3] = 1;
            board[4] = 1;


            Console.WriteLine(board[0]);
            Console.WriteLine(board[1]);
            Console.WriteLine(board[2]);
        }

    }
}
