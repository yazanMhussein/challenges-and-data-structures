using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreesCode.TreeSecondMaxValue;
namespace TreesCode
{
    public class Program
    {
        static void Main(string[] args)
        {
            BinaryTree tree = new BinaryTree(20);
            tree.Insert(10);
            tree.Insert(30);
            tree.Insert(5);
            tree.Insert(15);
            tree.Insert(25);
            tree.Insert(35);

            SecondMaxFinder secondMaxFinder = new SecondMaxFinder();
            int secondMax = secondMaxFinder.FindSecondMax(tree.Root);

            Console.WriteLine("The second maximum value in the tree is: " + secondMax);
        } 
    }
}
