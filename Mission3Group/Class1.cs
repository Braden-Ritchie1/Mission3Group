using System;
using System.Collections.Generic;
using System.Text;
namespace Mission3Group
{
    class Support
    {
        // receive board
        public string[] gameBoard;
        public void ReceiveBoard(string[] newArray)
        {
            gameBoard = newArray;
        }
        // print board
        public void printBoard()
        {
            Console.WriteLine("   |   |   ");
            Console.WriteLine(" {0} | {1} | {2} ", gameBoard[0], gameBoard[1], gameBoard[2]);
            Console.WriteLine("___|___|___");
            Console.WriteLine("   |   |   ");
            Console.WriteLine(" {0} | {1} | {2} ", gameBoard[3], gameBoard[4], gameBoard[5]);
            Console.WriteLine("___|___|___");
            Console.WriteLine("   |   |   ");
            Console.WriteLine(" {0} | {1} | {2} ", gameBoard[6], gameBoard[7], gameBoard[8]);
            Console.WriteLine("   |   |   ");

        }
        public static int CheckWin(string[] gameBoard)
        {
            Support s = new Support();
            // Horzontal Winning Condtion
            if (gameBoard[0] == gameBoard[1] && gameBoard[1] == gameBoard[2])
            {
                return 1;
            }
            else if (gameBoard[3] == gameBoard[4] && gameBoard[4] == gameBoard[5])
            {
                return 1;
            }
            else if (gameBoard[6] == gameBoard[7] && gameBoard[7] == gameBoard[8])
            {
                return 1;
            }
            // Vertical Winning Condtion
            else if (gameBoard[0] == gameBoard[3] && gameBoard[3] == gameBoard[6])
            {
                return 1;
            }
            else if (gameBoard[1] == gameBoard[4] && gameBoard[4] == gameBoard[7])
            {
                return 1;
            }
            else if (gameBoard[2] == gameBoard[5] && gameBoard[5] == gameBoard[8])
            {
                return 1;
            }
            // Diagonal Winning Condition
            else if (gameBoard[0] == gameBoard[4] && gameBoard[4] == gameBoard[8])
            {
                return 1;
            }
            else if (gameBoard[2] == gameBoard[4] && gameBoard[4] == gameBoard[6])
            {
                return 1;
            }
            // Checking For Tie
            else if (gameBoard[0] != "1" && gameBoard[1] != "2" && gameBoard[2] != "3" && gameBoard[3] != "4" && gameBoard[4] != "5" && gameBoard[5] != "6" && gameBoard[6] != "7" && gameBoard[7] != "8" && gameBoard[8] != "9")
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
