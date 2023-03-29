using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace sergeantTheyDunHitThePentagon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //all of this is me copying my tictactoe 
            string[,] gameBoard = new string[10, 10];
            Console.ForegroundColor = ConsoleColor.Green;
            string currentPlayer = "O";
            string humanPlayerHit = "H";
            Console.ForegroundColor = ConsoleColor.Red;
            string humanPlayerMiss = "M";
            Console.ForegroundColor = ConsoleColor.Green;
            string aiPlayerHit = "H";
            Console.ForegroundColor = ConsoleColor.Red;
            string aiPlayerMiss = "M";
            int rowMove = 0;
            int columnMove = 0;
            bool gameOver = false;
            bool winOrDraw = false;
            char playAgain = ' ';
            Random random = new Random();
            IntitialiseGameBoard(gameBoard);
            DisplayBoard(gameBoard);

            while (!gameOver)
            {
                takeTurn(gameBoard, ref currentPlayer, ref rowMove, ref columnMove, ref random);
                DisplayBoard(gameBoard);
                winOrDraw = checkForWin(gameBoard);

                if (winOrDraw)
                {
                    Console.WriteLine("Do you want to play again? Y for yes and any other to exit.");
                    playAgain = Convert.ToChar(Console.ReadLine());

                    if (playAgain != 'Y')
                    {
                        gameOver = true;
                    }
                    else
                    {
                        IntitialiseGameBoard(gameBoard);
                        DisplayBoard(gameBoard);
                    }
                }
            }

        }
        private static bool checkForWin(string[,] gameBoard)
        {
            bool result = false;

            for (int i = 0; i < 3; i++)
            {
                if (gameBoard[0, i] != " " && gameBoard[0, i] == gameBoard[1, i] && gameBoard[1, i] == gameBoard[2, i])
                {
                    Console.WriteLine("WE HAVE A WINNER");
                    result = true;
                }
            }
            for (int i = 0; i < 3; i++)
            {
                if (gameBoard[i, 0] != " " && gameBoard[i, 0] == gameBoard[i, 1] && gameBoard[i, 1] == gameBoard[i, 2])
                {
                    Console.WriteLine("WE HAVE A WINNER");
                    result = true;
                }
            }
            for (int i = 0; i < 3; i++)
            {
                if (gameBoard[i, 0] != " " && gameBoard[i, 0] == gameBoard[i, 1] && gameBoard[i, 1] == gameBoard[i, 2])
                {
                    Console.WriteLine("WE HAVE A WINNER");
                    result = true;
                }
            }
            if (gameBoard[0, 0] != " " && gameBoard[0, 0] == gameBoard[1, 1] && gameBoard[1, 1] == gameBoard[2, 2])
            {
                Console.WriteLine("WE HAVE A WINNER");
                result = true;
            }
            if (gameBoard[0, 2] != " " && gameBoard[0, 2] == gameBoard[1, 1] && gameBoard[1, 1] == gameBoard[2, 0])
            {
                Console.WriteLine("WE HAVE A WINNER");
                result = true;
            }

            return result;

        }

        private static void IntitialiseGameBoard(string[,] gameBoard)
        {

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    gameBoard[i, j] = " ";
                }

            }

        }

        //my little battleship thing
        private static void DisplayBoard(string[,] gameBoard)
        {
            for (int i = 0; i < 1; i++)
            {
                //cool game card thing
                Console.WriteLine(" ");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("                         *********************************************");
                Console.Write("                         *"); Console.ForegroundColor = ConsoleColor.White; Console.Write("    Welcome to The Battleship Game!!!     "); Console.ForegroundColor = ConsoleColor.DarkBlue; Console.WriteLine(" *");
                Console.WriteLine("                         *********************************************");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" ");


                Console.WriteLine("                YOUR BOAT'S                                         OPPS BOAT'S             ");
                Console.WriteLine("   1   2   3   4   5   6   7   8   9  10               1   2   3   4   5   6   7   8   9  10");
                Console.WriteLine("A|   |   |   |   |   |   |   |   |   |   |          B|   |   |   |   |   |   |   |   |   |   |");
                Console.WriteLine("B|   |   |   |   |   |   |   |   |   |   |          B|   |   |   |   |   |   |   |   |   |   |");
                Console.WriteLine("C|   |   |   |   |   |   |   |   |   |   |          C|   |   |   |   |   |   |   |   |   |   |");
                Console.WriteLine("D|   |   |   |   |   |   |   |   |   |   |          D|   |   |   |   |   |   |   |   |   |   |");
                Console.WriteLine("E|   |   |   |   |   |   |   |   |   |   |          E|   |   |   |   |   |   |   |   |   |   |");
                Console.WriteLine("F|   |   |   |   |   |   |   |   |   |   |          F|   |   |   |   |   |   |   |   |   |   |");
                Console.WriteLine("G|   |   |   |   |   |   |   |   |   |   |          G|   |   |   |   |   |   |   |   |   |   |");
                Console.WriteLine("H|   |   |   |   |   |   |   |   |   |   |          H|   |   |   |   |   |   |   |   |   |   |");
                Console.WriteLine("I|   |   |   |   |   |   |   |   |   |   |          I|   |   |   |   |   |   |   |   |   |   |");
                Console.WriteLine("J|   |   |   |   |   |   |   |   |   |   |          J|   |   |   |   |   |   |   |   |   |   |");
                Console.WriteLine("J|   |   |   |   |   |   |   |   |   |   |          J|   |   |   |   |   |   |   |   |   |   |");

            }


        }

        //just my gameover from the tictactoe
        private static void takeTurn(string[,] gameBoard, ref string currentPlayer, ref int rowMove, ref int columnMove, ref Random random)
        {
            Console.Write("Enter row number 1 to 10:");
            rowMove = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter column letter from A to J:");
            columnMove = Convert.ToInt32(Console.ReadLine());
            if (currentPlayer == "X")
            {
                if (gameBoard[rowMove - 1, columnMove - 1] == " ")
                {
                    gameBoard[rowMove - 1, columnMove - 1] = currentPlayer;
                    if (currentPlayer == "X")
                    {
                        currentPlayer = "X";
                    }
                    else
                    {
                        currentPlayer = "X";
                    }
                }
                else
                {
                    Console.WriteLine("POSITION ALREADY TAKEN. TRY AGAIN");
                    takeTurn(gameBoard, ref currentPlayer, ref rowMove, ref columnMove, ref random);
                }
            }
            else
            {
                rowMove = random.Next(10);
                columnMove = random.Next(10);
                if (gameBoard[rowMove, columnMove] == " ")
                {
                    gameBoard[rowMove, columnMove] = currentPlayer;
                    if (currentPlayer == "X")
                    {
                        currentPlayer = "X";
                    }
                    else
                    {
                        currentPlayer = "X";
                    }
                }
                else
                {
                    Console.WriteLine("POSITION ALREADY TAKEN. TRY AGAIN");
                    takeTurn(gameBoard, ref currentPlayer, ref rowMove, ref columnMove, ref random);
                }

            }

        }

    }
}
