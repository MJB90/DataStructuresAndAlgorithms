using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.Recursion
{
    class ReverseString
    {
        public static string RReverse(string str, int i)
        {
            if (i == str.Length)
            {
                return "";
            }
            else
            {
                return RReverse(str,i+1) + str[i];
            }
        }

        public static void Reverse(string str)
        {
            Console.WriteLine("'{0}' reversed is '{1}'", str, RReverse(str, 0));
        }

        static void Main()
        {
            Reverse("hello world");
            Reverse("apple");
            Reverse("toy");
            Reverse("");

        }
    }
}
