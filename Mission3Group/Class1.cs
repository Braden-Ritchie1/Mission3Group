using System;
using System.Collections.Generic;
using System.Text;

namespace Mission3Group
{
    class Support
    {
        // receive board
        class Receive
        {
            private string[] gameBoard;
            public void SetArray(string[] newArray)
            {
                gameBoard = newArray;
            }

            // print board
            public void printArray()
            {
                Console.WriteLine(gameBoard);
            }
        }

        // identify results

    }
}
