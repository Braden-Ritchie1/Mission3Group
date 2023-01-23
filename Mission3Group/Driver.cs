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

            int[] choices = new int[10];
            for (int i=0; i<10; i++)
            {
                choices[i] = i + 1;
            }
            

            Console.WriteLine("   |   |   ");
            Console.WriteLine(" " + choices[0] + " | " + choices[1] + " | " + choices[2] + " ");
            Console.WriteLine("___|___|___");
            Console.WriteLine("   |   |   ");
            Console.WriteLine(" " + choices[3] + " | " + choices[4] + " | " + choices[5] + " ");
            Console.WriteLine("___|___|___");
            Console.WriteLine("   |   |   ");
            Console.WriteLine(" " + choices[6] + " | " + choices[7] + " | " + choices[8] + " ");
            Console.WriteLine("   |   |   ");


            string[] board = new string[9];
            Console.WriteLine("Player 1, Choose your number: ");

            int player1num = Convert.ToInt32(Console.ReadLine());
            Console.Write(board[0]);

        }

    }
}
