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

            //int top[0] = new int[3];
            //int middle[1] = new int[3];
            //bottom[]



            int[][] board = new int[3][];
                new int[3] {1, 1, 1},
                new int[3] {0, 0, 0 },
                new int[3] {1, 1, 1}
            };
            
            Console.WriteLine(board[0]);
            Console.WriteLine(board[1]);
            Console.WriteLine(board[2]);
        }

    }
}
