using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BST
{
    public class Node
    {
        public Node left { get; set; }
        public Node right { get; set; }
        public int value { get; set; }

        public Node(int n)
        {
            value = n;
            left = null;
            right = null;
        }

        public void AddNode(Node n)
        {
            if (n.value < value)
            {
                if (left == null) left = n;
                else left.AddNode(n);
            }
            else if (n.value > value)
            {
                if (right == null) right = n;
                else right.AddNode(n);
            }
        }

        public void Visit()
        {
            left?.Visit();
            Console.WriteLine(value);
            right?.Visit();
        }

        public Node Search(int val)
        {
            return val == value ? this
                : val > value ? right?.Search(val) 
                : val < value ? left?.Search(val)
                : null;
        }
    }
}
