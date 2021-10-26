using System;

namespace TIC_TAC_TOE
{
    class Program
    {
        
        char[] arr = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        int player = 1;
         int flog = 0;


       public static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("player 1:X and player2:0");
                Console.WriteLine("\n");
                if (player % 2 == 0)
                  {

                        Console.WriteLine("Player 2 Chance");

                    }

                    else

                    {

                        Console.WriteLine("Player 1 Chance");

                    }

                Console.WriteLine("\n");


                