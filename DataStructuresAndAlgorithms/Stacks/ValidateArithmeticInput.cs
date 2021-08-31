using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.Stacks
{
    class ValidateArithmeticInput
    {
        private static bool IsOpenDelimiter(char ch)
        {
            return ch == '(' || ch == '[' || ch == '{';
        }

        private static bool IsCloseDelimiter(char ch)
        {
            return ch == ')' || ch == ']' || ch == '}';
        }

        private static bool IsPaired(char open, char close)
        {
            return (open == '(' && close == ')') ||
                      (open == '[' && close == ']') ||
                      (open == '{' && close == '}');
        }

        public static bool Validate(string input)
        {
            bool isValid = true;
            int i;
            Stack<char> brackets = new Stack<char>();

            for (i = 0; i < input.Length; i++)
            {
                if (IsOpenDelimiter(input[i]))
                {
                    brackets.Push(input[i]);
                }
                else if (IsCloseDelimiter(input[i]))
                {
                    if (brackets.Count == 0 || IsPaired(input[i],brackets.Pop()))
                    {
                        isValid = false;
                        break;
                    }
                }
            }

            if (brackets.Count == 0)
                return isValid;
            else return false;
        }
        public static void Main()
        {
            string input;

            Console.Write("Enter the string of operations : ");
            input = Console.ReadLine();

            input.Replace(" ", null);
            Console.WriteLine(Validate(input));
        }
    }
}
