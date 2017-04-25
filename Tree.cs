using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BST
{
    public class Tree
    {
        public Node RootNode { get; set; }

        public Tree()
        {
            RootNode = null;
        }

        public void AddValue(int n)
        {
            Node node = new Node(n);

            if (RootNode == null) RootNode = node;
            else RootNode.AddNode(node);
        }

        public void Traverse() => RootNode.Visit();

        public Node Search(int val) => RootNode.Search(val);
       
    }
}
