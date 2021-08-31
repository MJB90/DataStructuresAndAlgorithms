using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.Lists
{
    class Node
    {
        public string data { get; set; }
        public Node Next { get; set; }

        public Node(string data)
        {
            this.data = data;
            Next = null;
        }
        
    }
}
