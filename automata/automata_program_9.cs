using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication80
{
    class Program
    {
        static void Main(string[] args)
        {
            int value = 0;
            int value1 = 0;
            int currentState = 0;
            string string1 = null;
            string string2 = null;
            string string3 = null;
            int[] mazeValues = new int[16];
            int[,] mazeStates = new int[16, 16];

            mazeValues[0] = 5;
            mazeValues[1] = 2;
            mazeValues[2] = 3;
            mazeValues[3] = 4;

            mazeValues[4] = 3;
            mazeValues[5] = 0;
            mazeValues[6] = 1;
            mazeValues[7] = 2;

            mazeValues[8] = 4;
            mazeValues[9] = 5;
            mazeValues[10] = 1;
            mazeValues[11] = 7;

            mazeValues[12] = 6;
            mazeValues[13] = 0;
            mazeValues[14] = 2;
            mazeValues[15] = 4;

            for (int i=0;i<mazeValues.Length;i++)
            {
                Console.Write(mazeValues[i]+" ");
                if( (i+1)  % 4 == 0 )
                {
                    Console.WriteLine("");
                }
            }

            mazeStates[0, 0] = 0;
            mazeStates[0, 1] = 4;
            mazeStates[0, 2] = 0;
            mazeStates[0, 3] = 1;

            mazeStates[1, 0] = 1;
            mazeStates[1, 1] = 5;
            mazeStates[1, 2] = 0;
            mazeStates[1, 3] = 2;

            mazeStates[2, 0] = 2;
            mazeStates[2, 1] = 6;
            mazeStates[2, 2] = 1;
            mazeStates[2, 3] = 3;

            mazeStates[3, 0] = 3;
            mazeStates[3, 1] = 7;
            mazeStates[3, 2] = 2;
            mazeStates[3, 3] = 4;

            mazeStates[4, 0] = 0;
            mazeStates[4, 1] = 8;
            mazeStates[4, 2] = 3;
            mazeStates[4, 3] = 5;

            mazeStates[5, 0] = 1;
            mazeStates[5, 1] = 9;
            mazeStates[5, 2] = 4;
            mazeStates[5, 3] = 6;

            mazeStates[6, 0] = 2;
            mazeStates[6, 1] = 10;
            mazeStates[6, 2] = 5;
            mazeStates[6, 3] = 7;

            mazeStates[7, 0] = 3;
            mazeStates[7, 1] = 11;
            mazeStates[7, 2] = 6;
            mazeStates[7, 3] = 8;

            mazeStates[8, 0] = 4;
            mazeStates[8, 1] = 12;
            mazeStates[8, 2] = 7;
            mazeStates[8, 3] = 9;

            mazeStates[9, 0] = 5;
            mazeStates[9, 1] = 13;
            mazeStates[9, 2] = 8;
            mazeStates[9, 3] = 10;

            mazeStates[10, 0] = 6;
            mazeStates[10, 1] = 14;
            mazeStates[10, 2] = 9;
            mazeStates[10, 3] = 11;

            mazeStates[11, 0] = 7;
            mazeStates[11, 1] = 15;
            mazeStates[11, 2] = 10;
            mazeStates[11, 3] = 12;

            mazeStates[12, 0] = 8;
            mazeStates[12, 1] = 12;
            mazeStates[12, 2] = 11;
            mazeStates[12, 3] = 13;

            mazeStates[13, 0] = 9;
            mazeStates[13, 1] = 13;
            mazeStates[13, 2] = 12;
            mazeStates[13, 3] = 14;

            mazeStates[14, 0] = 10;
            mazeStates[14, 1] = 14;
            mazeStates[14, 2] = 13;
            mazeStates[14, 3] = 15;

            mazeStates[15, 0] = 11;
            mazeStates[15, 1] = 15;
            mazeStates[15, 2] = 14;
            mazeStates[15, 3] = 15;


            Console.WriteLine("");
            Console.WriteLine("");

            char playAgain = 'y';

            while (playAgain != 'n')
            {
                value = 0;
                currentState = 0;
                Console.WriteLine("enter the string where 0 will go up, 1 will go down, 2 will go left and 3 will go right");
                Console.WriteLine("For player 1");

                Console.WriteLine("enter the 1st string");
                string1 = Console.ReadLine();

                for (int i = 0; i < string1.Length; i++)
                {
                    currentState = mazeStates[currentState, int.Parse(string1[i].ToString())];
                    value += mazeValues[currentState];
                }

                currentState = 0;


                Console.WriteLine("enter the 2nd string");
                string2 = Console.ReadLine();

                currentState = 0;

                for (int i = 0; i < string2.Length; i++)
                {
                  currentState = mazeStates[currentState, int.Parse(string2[i].ToString())];
                  value += mazeValues[currentState];
                }

                Console.WriteLine("enter the 3rd string");
                string3 = Console.ReadLine();

                currentState = 0;

                for (int i = 0; i < string3.Length; i++)
                {
                  currentState = mazeStates[currentState, int.Parse(string3[i].ToString())];
                  value += mazeValues[currentState];
                }

                Console.WriteLine("The final score for player1 is " + value);

                Console.WriteLine("For player 2");

                currentState = 0;
                value1 = 0;
                string1 = null;
                Console.WriteLine("enter the 1st string");
                string1 = Console.ReadLine();

                for (int i = 0; i < string1.Length; i++)
                {
                    currentState = mazeStates[currentState, int.Parse(string1[i].ToString())];
                    value1 += mazeValues[currentState];
                }

                currentState = 0;

                string2 = null;
                Console.WriteLine("enter the 2nd string");
                string2 = Console.ReadLine();

                currentState = 0;

                for (int i = 0; i < string2.Length; i++)
                {
                    currentState = mazeStates[currentState, int.Parse(string2[i].ToString())];
                    value1 += mazeValues[currentState];
                }


                string3 = null;
                Console.WriteLine("enter the 3rd string");
                string3 = Console.ReadLine();

                currentState = 0;

                for (int i = 0; i < string3.Length; i++)
                {
                    currentState = mazeStates[currentState, int.Parse(string3[i].ToString())];
                    value1 += mazeValues[currentState];
                }

                Console.WriteLine("The final score for player2 is " + value1);

                Console.WriteLine("");
                Console.WriteLine("");

                if(value>value1)
                {
                    Console.WriteLine("Player 1 is the winner");
                }
                else if(value<value1)
                {
                    Console.WriteLine("Player 2 is the winner");
                }
                else if(value==value1)
                {
                    Console.WriteLine("This game is a draw");
                }

                Console.WriteLine("");
                Console.WriteLine("");

                Console.WriteLine("Do you want to play again?(y/n)");
                playAgain=Convert.ToChar(Console.ReadLine());
            }
            Console.ReadKey();
        }
    }
}