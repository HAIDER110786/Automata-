using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP1
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] alparr = new string[20];
            int j = 0;

            Console.WriteLine("enter the alphabets");
            string alphabets = Console.ReadLine();

            for(int i=0;i<alphabets.Length;i++)
            {
                if(alphabets[i]!='{' && alphabets[i]!='}')
                {
                    if(alphabets[i] != ',')
                    {
                        alparr[j] += alphabets[i];
                    }
                    else
                    {
                        j++;
                    }
                }
            }

            //for(int q=0;q<alphabets.Length;q++)
            //{
            //    Console.WriteLine(alparr[q]);
            //}

            string temp = null;
            bool flag = false;

            for(int k=0;k<alparr.Length;k++)
            {
                if(alparr[k]!=null)
                {
                    for(int l=k+1;l<alparr.Length;l++)
                    {
                        if(alparr[l]!=null)
                        {
                            if(alparr[k].Length >= alparr[l].Length)
                            {
                                for(int m=0;m<alparr[l].Length;m++)
                                {
                                    temp += alparr[k][m];
                                }
                                if(temp==alparr[l])
                                {
                                    flag = true;
                                }
                            }
                            else if (alparr[k].Length < alparr[l].Length)
                            {
                                for (int m = 0; m < alparr[k].Length; m++)
                                {
                                    temp += alparr[l][m];
                                }
                                if (temp == alparr[k])
                                {
                                    flag = true;
                                }
                            }
                        }
                        else
                        {
                            break;
                        }
                    }
                }
                else
                {
                    break;
                }
            }
            if(flag==true)
            {
                Console.WriteLine("invalid alphabets");
            }
            else
            {
                Console.WriteLine("valid alphabets");
            }
	}
    }
}