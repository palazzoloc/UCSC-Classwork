using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBoard_Queens
{
    class Program
    {
        int queens = 8;
        //int n = Console.ReadLine("Please enter a number between 1 and 8: ");
        bool queenPresent = new queenPresent(int board[][], int col);
        bool findSafeSpot = new findSafeSpot(int board[n][n], int row, int col);

        static void Main(string[] args)
        {
            Console.WriteLine("This is the main function");
        }
        
        #region Helper Methods
        static void display()(int board[n][n])
        {
            for (int row = 0; row < n; row++)
            {
                for(int col = 0; col < n; col++)
                {
                    Console.WriteLine("You have {0} rows", row);
                    Console.WriteLine("You have {0} columns", col);
                }

}
