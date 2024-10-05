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
            BinaryTree Btree = new BinaryTree(1);  // Root node
            Btree.Root = new TNode(2);
            Btree.Root.Left = new TNode(3);
            Btree.Root.Right = new TNode(4);
            Btree.Root.Left.Left = new TNode(5);
            Btree.Root.Left.Right = new TNode(6);
            Btree.Root.Right.Right = new TNode(7);
            Btree.Root.Left.Left.Left = new TNode(8);
            FindMaxLevelNodes maxLevelNodes = new FindMaxLevelNodes();
            int maxLevel = maxLevelNodes.FindMaxLevelNode(Btree.Root); 
            Console.WriteLine("Level with maximum nodes: " + maxLevel);
        }
    }
}
