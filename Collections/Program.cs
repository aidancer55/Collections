using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку");
            string cnt = Console.ReadLine();
            Console.WriteLine(Check(cnt));
            Console.ReadKey();
        }
        static bool Check(string cnt)
        {
            Stack<char> stack = new Stack<char>();
            foreach (char c in cnt)
            {
                switch (c)
                {
                    case '{':
                    case '(':
                    case '[':
                        stack.Push(c);
                        break;

                    case '}':
                        if (stack.Count == 0)
                            return false;
                        if (stack.Pop() != '{')
                            return false;
                        break;
                    case ']':
                        if (stack.Count == 0)
                            return false;
                        if (stack.Pop() != '[')
                            return false;
                        break;
                    case ')':

                        if (stack.Count == 0)
                            return false;
                        if (stack.Pop() != '(')
                            return false;
                        break;
                }
            }
            return stack.Count == 0;
        }
    }
}
