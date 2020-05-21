using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9__2_
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            Stack<char> bracket = new Stack<char>();
            bool a = false;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '(')
                {
                    bracket.Push(str[i]);
                }
                else if (str[i] == ')')
                {
                    if (bracket.Count > 0)
                    {
                        bracket.Pop();
                    }
                    else
                    {
                        Console.WriteLine("Выражение не верно");
                        a = true;
                        break;
                    }
                }
            }
            if (bracket.Count > 0 && !a)
            {
                Console.WriteLine("Выражение не верно");
            }
            else if (!a)
            {
                Console.WriteLine("Выражение верно");
            }
            

        }
    }
}
