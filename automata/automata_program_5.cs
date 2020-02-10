using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



using System.Threading.Tasks;

namespace ConsoleApplication50
{
    class Program
    {
        static void Main(string[] args)
        {
                string[] Lang = { "0", "1" };
                int No_of_States;
                int No_of_Final_stated;
                string Word = null;
                Console.WriteLine("1. Enter number of states for DFA");
                No_of_States = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("2. Define Transitions");
                int[,] Transition_Table = new int[No_of_States, Lang.Length];
                for (int row = 0; row < No_of_States; row++)
                {
                    for (int col = 0; col < Lang.Length; col++)
                    {
                        Console.WriteLine("If input is " + col);
                        Console.Write("Transition from state " + row + " to ");
                        Transition_Table[row, col] = Convert.ToInt32(Console.ReadLine());
                    }
                }
                Console.WriteLine("3. Enter number of Final States");
                No_of_Final_stated = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("4. Define Final States");
                int[] Final_states = new int[No_of_Final_stated];
                for (int j = 0; j < Final_states.Length; j++)
                {
                    Final_states[j] = Convert.ToInt32(Console.ReadLine());
                }
                while (Word != "N" || Word != "n")
                {
                    Console.WriteLine("5. Enter word/ Or 'Type 'N/n' to Exit");
                    Word = Console.ReadLine();
                    int current_State = 0;
                    for (int s = 0; s < Word.Length; s++)
                    {
                        current_State = Transition_Table[current_State, int.Parse(Word[s].ToString())];
                    }
                    bool check = false;
                    if (Word != null)
                    {
                        for (int j = 0; j < Final_states.Length; j++)
                        {
                            if (current_State == Final_states[j])
                            {
                                check = true;
                                break;
                            }
                        }
                    }
                    if (check)
                        Console.WriteLine("Word is valid");
                    else
                        Console.WriteLine("Word is invalid");
                }
            }
        }
    }
}