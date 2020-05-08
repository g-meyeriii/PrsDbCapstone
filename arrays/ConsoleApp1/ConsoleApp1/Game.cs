using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays
{
    class Game
    {



        public static void TickTackToe()
        {
            int[,] MyArray = new int[,]
            {
             { 1 , 2 ,  3},
             { 4 , 5 ,  6},
             { 7 , 8 ,  9},
            };

            int counter = 1;
            string winner;


            Console.WriteLine("Player 1: please pick a number from the board and press enter");
            string input = Console.ReadLine(); counter++;
            int move;
            
            bool success = int.TryParse(input,out move);
                if(success)
                {
                Console.WriteLine("" );
                }
                else
                {
                    Console.WriteLine("Ensure you entered a number");
                }

            if (counter % 2 <=0)
            {
                
                Console.WriteLine("Player 2: Choose your field");
            }
            else
                
            {
                Console.WriteLine("Player 1: Choos your field");
            }



            //Console.WriteLine("The winner is {0}", winner);
            return;
        }


    }
}
