using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.Recursion
{
    class CountStrLen
    {
        public static int RCount(string str)
        {
            if (str=="")
            {
                return 0;
            }
            else
            {
                return 1 + RCount(str.Substring(1));
            }
        }

        public static void Count(string str)
        {
            Console.WriteLine("'{0}' has a length of {1}", str, RCount(str));
        }

        static void Main()
        {
            Count("hello world");
            Count("apple");
            Count("toy");
            Count("");

        }
    }
}
