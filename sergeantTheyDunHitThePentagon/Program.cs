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
            string humanPlayerHit = "H";
            Console.ForegroundColor = ConsoleColor.Red;
            string humanPlayerMiss = "M";
            int rowMove = 0;
            int columnMove = 0;
            bool gameOver = false;
            bool winOrDraw = false;
            char playAgain = ' ';
            Random random = new Random();
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
            private static void GameBoard(string[,] gameBoard)
            {

                Console.WriteLine("                YOUR BOAT'S                                         OPPS BOAT'S             ");
                Console.WriteLine("   1   2   3   4   5   6   7   8   9  10               1   2   3   4   5   6   7   8   9  10");
                Console.WriteLine("A| \" + gameBoard[i, 0] + \"  | \" + gameBoard[i, 0] + \"  | \" + gameBoard[i, 0] + \"  | \" + gameBoard[i, 0] + \"  | \" + gameBoard[i, 0] + \"  | \" + gameBoard[i, 0] + \"  | \" + gameBoard[i, 0] + \"  | \" + gameBoard[i, 0] + \"  | \" + gameBoard[i, 0] + \"  | \" + gameBoard[i, 0] + \"  |          A|   |   |   |   |   |   |   |   |   |   |");
                Console.WriteLine("B|   |   |   |   |   |   |   |   |   |   |          B|   |   |   |   |   |   |   |   |   |   |");
                Console.WriteLine("C|   |   |   |   |   |   |   |   |   |   |          C|   |   |   |   |   |   |   |   |   |   |");
                Console.WriteLine("D|   |   |   |   |   |   |   |   |   |   |          D|   |   |   |   |   |   |   |   |   |   |");
                Console.WriteLine("E|   |   |   |   |   |   |   |   |   |   |          E|   |   |   |   |   |   |   |   |   |   |");
                Console.WriteLine("F|   |   |   |   |   |   |   |   |   |   |          F|   |   |   |   |   |   |   |   |   |   |");
                Console.WriteLine("G|   |   |   |   |   |   |   |   |   |   |          G|   |   |   |   |   |   |   |   |   |   |");
                Console.WriteLine("H|   |   |   |   |   |   |   |   |   |   |          H|   |   |   |   |   |   |   |   |   |   |");
                Console.WriteLine("I|   |   |   |   |   |   |   |   |   |   |          I|   |   |   |   |   |   |   |   |   |   |");
                Console.WriteLine("J|   |   |   |   |   |   |   |   |   |   |          J|   |   |   |   |   |   |   |   |   |   |");

            }

        }
    }
}
