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
            string[,] yourBoard = new string[10, 10];
            string[,] aiBoard = new string[10, 10];
            Console.ForegroundColor = ConsoleColor.Green;
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
            Random randoms = new Random();
            IntitialiseGameBoard(gameBoard);
            DisplayBoard(gameBoard);

            //cool game card thing
            Console.WriteLine(" ");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("                         ********************************************");
            Console.Write("                         *"); Console.ForegroundColor = ConsoleColor.White; Console.Write("    Welcome to The Battleship Game!!!     "); Console.ForegroundColor = ConsoleColor.Blue; Console.WriteLine("*");
            Console.WriteLine("                         ********************************************");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" ");

            //my little battleship thing
            private static void DisplayBoard(string[,] gameBoard)
            {
                for (int i = 0; i < 10; i++)
                {
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

            //just my gamneover from the tictactoe
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
                            currentPlayer = "O";
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
                    rowMove = random.Next(3);
                    columnMove = random.Next(3);
                    if (gameBoard[rowMove, columnMove] == " ")
                    {
                        gameBoard[rowMove, columnMove] = currentPlayer;
                        if (currentPlayer == "X")
                        {
                            currentPlayer = "O";
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
}
