using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication58
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] index = new int[20, 20];
            int finalState = 4;

            index[0, 0] = 1;
            index[0, 1] = 0;
            index[1, 0] = 1;
            index[1, 1] = 2;
            index[2, 0] = 3;
            index[2, 1] = 0;
            index[3, 0] = 4;
            index[3, 1] = 2;
            index[4, 0] = 1;
            index[4, 1] = 0;


            int currentstate = 0;
            char option = 'y';
            while (option != 'n')
            {
                Console.WriteLine("enter the string");
                string str = Console.ReadLine();

                int count = 0;
                for (int i = 0; i < str.Length; i++)
                {
                    currentstate = index[currentstate, int.Parse(str[i].ToString())];

                    if (currentstate == finalState)
                    {
                        count = count + 1;
                    }

                }
                Console.WriteLine("the count of 0100 in your program is " + count);
                Console.WriteLine("do you want to continue(y/n):");
                option = Convert.ToChar(Console.ReadLine());
            }
        }
    }
}
      