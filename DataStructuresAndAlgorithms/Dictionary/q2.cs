using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.Dictionary
{
    class q2
    {
        public static void PrintPairs(int[] a)
        {
            Dictionary<int, int> elements = new Dictionary<int, int>();
            int i;

            for (i = 0; i < a.Length; i++) elements[a[i]] = 1;

            for (i = 0; i < a.Length; i++)
            {
                if (elements.ContainsKey(10 - a[i]) && elements[a[i]]!=0 && a[i]!=10-a[i])
                {
                    elements[10 - a[i]] = 0;
                    Console.Write("{" + a[i] + "," + (10 - a[i]) + "},");
                }
            }
        }
        static void Main()
        {
            int[] a = { 1, 3, 2, 10, 4, 9, 7, 15, 6, 5 };

            PrintPairs(a);
        }
    }
}
