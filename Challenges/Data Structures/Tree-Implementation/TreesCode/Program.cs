using MaxLevelNodes;
using RightViewPrint;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using TreesCode.TreeSecondMaxValue;
namespace TreesCode
{
    public class Program
    {
        static void Main(string[] args)
        {
            BinaryTree Btree = new BinaryTree(1);
            Btree.Root.Left = new TNode(2);
            Btree.Root.Right = new TNode(3);
            Btree.Root.Left.Left = new TNode(4);
            Btree.Root.Left.Right = new TNode(5);
            MinimumDepth minDepthFinder = new MinimumDepth();
            int minDepth = minDepthFinder.FindMinimumDepth(Btree.Root);
            Console.WriteLine("Minimum depth: " + minDepth); 
        }
    }
}
