using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication54
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] states = new int[10];
            int[,] tt = new int[30,30];
            int finalState;
            string word = null;

            Console.WriteLine("enter the divisor");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the states");
            for (int i = 0; i < m ; i++)
            {
                states[i] = Convert.ToInt32(Console.ReadLine());
            }
            int[] language = { 1, 0 };
            for(int i=0;i<m;i++)
            {
                for(int j=0;j<language.Length;j++)
                {
                    Console.WriteLine("if the state is "+i);
                    Console.WriteLine("input of "+j+" will transit it to ");
                    tt[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            finalState = m - 1;
            while (word != "n")
            {
                Console.WriteLine("enter a number");
                int number = Convert.ToInt32(Console.ReadLine());

                int remains = number % m;
                Console.WriteLine(" ");
                Console.WriteLine("the remainder of this number is " + remains);
                Console.WriteLine(" ");


                string result = null;
                int remainder;
                int c = 0;
                int[] num = new int[10];
                while (number > 0)
                {
                    remainder = number % 2;
                    number /= 2;
                    result = remainder.ToString() + result;
                    num[c] = remainder;
                    c++;
                }

                int currentState = 0;
                for (int i = result.Length - 1; i >= 0; i--)
                {
                    currentState = tt[currentState, num[i]];
                }
                if (currentState == finalState)
                {
                    Console.WriteLine("the input string is valid");
                }
                else
                {
                    Console.WriteLine("the input string is invalid");
                }
                Console.WriteLine("do you want to continue??(y/n)");
                word = Console.ReadLine();
            }
        }
    }
}