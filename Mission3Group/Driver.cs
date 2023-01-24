using System;
using System.Collections.Generic;
using System.Text;

namespace Mission3Group
{
    class Driver
    {
        public void Board()
        {
            Support s = new Support();

            Console.WriteLine("Let's Play Tic-Tac-Toe!\n");

            int[] choices = new int[10];
            for (int i=0; i<10; i++)
            {
                choices[i] = i + 1;
            }
            Console.WriteLine("pick a number to fill in with an X or an O.");

            Console.WriteLine("   |   |   ");
            Console.WriteLine(" " + choices[0] + " | " + choices[1] + " | " + choices[2] + " ");
            Console.WriteLine("___|___|___");
            Console.WriteLine("   |   |   ");
            Console.WriteLine(" " + choices[3] + " | " + choices[4] + " | " + choices[5] + " ");
            Console.WriteLine("___|___|___");
            Console.WriteLine("   |   |   ");
            Console.WriteLine(" " + choices[6] + " | " + choices[7] + " | " + choices[8] + " ");
            Console.WriteLine("   |   |   ");


            string[] board = new string[9] {"1", "2", "3", "4", "5","6","7","8","9"};


            int win = 0;

            while (win == 0)
            {
                if(win == 0)
                {
                    Console.WriteLine("\nPlayer 1, Choose your number: ");

                    int player1num = Convert.ToInt32(Console.ReadLine());

                    board[player1num - 1] = "X";

                    s.ReceiveBoard(board);
                    s.printBoard();
                    win = Support.CheckWin(board);

                    if (win == 1)
                    {
                        Console.WriteLine("Player 1 has won!!!");
                    }

                    if (win == -1)
                    {
                        Console.WriteLine("You both tied!!!");
                    }
                }


                if (win == 0)
                {
                    Console.WriteLine("\nPlayer 2, Choose your number: ");

                    int player2num = Convert.ToInt32(Console.ReadLine());

                    board[player2num - 1] = "O";

                    s.ReceiveBoard(board);
                    s.printBoard();
                    win = Support.CheckWin(board);

                    if (win == 1)
                    {
                        Console.WriteLine("Player 2 has won!!!");
                    }

                    if(win == -1)
                    {
                        Console.WriteLine("You both tied!!!");
                    }

                }


            }


        }

    }
}
