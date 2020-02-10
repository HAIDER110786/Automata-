using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;

namespace ConsoleApplication73
{
    class Program
    {
        const int size = 5;
        const int size1 = 20;
        static char[] s = new char[size];
        static int[] s1 = new int[size1];
        static int top = -1;
        static int top1 = -1;
        static char a;
        static float result=0;

        public static void push1(int n1)
        {
            top1++;
            s1[top1] = n1;
        }

        public static void push(char n)
        {
            top++;
            s[top] = n;
        }

        public static char pop()
        {
            if (top == -1)
            {
                return a;
            }
            char item = s[top];
            top--;
            return item;
        }

        public static int pop1()
        { 
            int item1 = s1[top1];
            top1--;
            return item1;
        }


        public static int preference(char n)
        {
            switch (n)
            {
                case '+':
                case '-':
                    return 1;
                    break;
                case '*':
                case '/':
                case '%':
                    return 2;
                    break;
                case '^':
                    return 3;
                    break;
                default:
                    return 0;
                    break;
            }
        }

        static void Main(string[] args)
        {
            char value = 'a';
            int counter = 0;
            string p = null;
            int[] p1 = new int[10];
            string expression;
            Console.WriteLine("enter an arithmatic expression");
            expression = Console.ReadLine();
            push('(');
            expression = expression + ')'; 
            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] != '+' && expression[i] != '-' && expression[i] != '*' && expression[i] != '/' && expression[i] != '(' && expression[i] != ')')
                {
                    p += expression[i];
                }
                else
                {
                    if (expression[i] == '+' || expression[i] == '-' || expression[i] == '*' || expression[i] == '/')
                    {
                        int preference_1 = preference(expression[i]);
                        value = pop();
                        if (value != '(')
                        {
                            int preference_2 = preference(value);
                            if (preference_2 >= preference_1)
                            {
                                p += value;
                                push(expression[i]);
                            }
                            else
                            {
                                push(value);
                                push(expression[i]);
                            }
                        }
                        else
                        {
                            push(value);
                            push(expression[i]);
                        }
                    }
                    else
                    {
                        if (expression[i] == ')')
                        {
                            value = pop();
                            while (value != '(')
                            {
                                if (value != '(' && value != ')')
                                {
                                    p += value;
                                }
                                value = pop();
                                counter = counter - 1;
                            }
                        }
                        else
                        {
                            if (expression[i] == '(')
                            {
                                push(expression[i]);
                            }
                        }
                    }
                }
            }
            while (counter > 0)
            {
                value = pop();
                if (value == '(' || value == ')')
                {
                    int maafKaro = 3;
                }
                else
                {
                    p += value;
                }
                counter--;
            }
            Console.WriteLine(p);

            for(int i=0;i<p.Length;i++)
            {
                if(p[i]!='+' && p[i] != '-' && p[i] != '*' && p[i] != '/' && p[i] != '^' && p[i] != '*')
                {
                    int temp=(int.Parse(p[i].ToString()));
                    push1(temp);
                }
                else
                {
                    int answer = 0;
                    int a = pop1();
                    int b = pop1();  
                    switch (p[i])
                    {
                        case '+':
                            {
                                answer = b + a;
                                push1(answer);
                                break;
                            }
                        case '-':
                            {
                                answer = b - a;
                                push1(answer);
                                break;
                            }
                        case '*':
                            {
                                answer = b * a;
                                push1(answer);
                                break;
                            }
                        case '/':
                            {
                                answer = b / a;
                                push1(answer);
                                break;
                            }
                    }
                }
            }
            Console.Write(pop1());
            Console.ReadKey();
        }
    }
}