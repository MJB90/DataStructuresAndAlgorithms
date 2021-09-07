using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.Dictionary
{
    class q1
    {
        public static bool CheckSameSet(int[] a, int[] b)
        {
            bool sameSet = true;
            int i;
            Dictionary<int, int> aa = new Dictionary<int, int>();
            Dictionary<int, int> bb = new Dictionary<int, int>();

            for (i = 0; i < a.Length; i++)
            {
                if (aa.ContainsKey(a[i])) aa[a[i]]++;
                else aa[a[i]] = 1;
            }

            for (i = 0; i < b.Length; i++)
            {
                if (bb.ContainsKey(b[i])) bb[b[i]]++;
                else bb[b[i]] = 1;
            }

            foreach(int k in aa.Keys)
            {
                if (bb.ContainsKey(k)==false || aa[k] != bb[k])
                {
                    sameSet = false;
                    break;
                }
                    
            }
            return sameSet;
        }

        static void Main()
        {
            int[] a = { 2,4, 2, 4 ,3};
            int[] b = { 4,2,3,4,2 };

            Console.WriteLine(CheckSameSet(a, b));
        }
    }
}
