using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BST
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Tree tree = new Tree();
            Random rnd = new Random();
            for (int i = 0; i < 20; i++)
            {
                tree.AddValue(rnd.Next(100));
            }
            
            tree.Traverse();

            int search = int.Parse(Console.ReadLine());
            Node found = tree.Search(search);

            if(found != null) Console.WriteLine($"Found {found.value}");
            Console.ReadKey();
        }
    }
}
