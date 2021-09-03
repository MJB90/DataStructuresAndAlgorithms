using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.Recursion
{
    class ReverseString
    {
        public static string RReverse(string str)
        {
            if (str == "")
            {
                return "";
            }
            else
            {
                return RReverse(str.Substring(1)) + str[0];
            }
        }

        public static void Reverse(string str)
        {
            Console.WriteLine("'{0}' reversed is '{1}'", str, RReverse(str));
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
