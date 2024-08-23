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
            BinaryTree Btree = new BinaryTree(9);
            Btree.Root = new TNode(9);
            Btree.Root.Left = new TNode(8);
            Btree.Root.Right = new TNode(12);
            Btree.Root.Left.Left = new TNode(3);
            Btree.Root.Left.Right = new TNode(7);
            Btree.Root.Right.Left = new TNode(17);
            Btree.Root.Right.Right = new TNode(23);
            Btree.Root.Left.Left.Right = new TNode(4);

            int leafSum = Btree.LeafSum();
            Console.WriteLine("Sum of all leaf nodes: " + leafSum); 
        } 
    }
}
