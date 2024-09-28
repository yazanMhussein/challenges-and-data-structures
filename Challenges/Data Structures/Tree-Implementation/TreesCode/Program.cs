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
            // Create and initialize the binary tree
            BinaryTree Btree = new BinaryTree(2);  // Adjusted to pass rootValue
            Btree.Root.Left = new TNode(3);
            Btree.Root.Right = new TNode(5);
            Btree.Root.Left.Left = new TNode(4);
            Btree.Root.Right.Right = new TNode(6);
            Btree.Root.Left.Left.Right = new TNode(7);

            // Create an instance of PrintRightView and print the right view of the tree
            PrintRightView rightViewPrinter = new PrintRightView(Btree);
            Console.WriteLine("Right view of the binary tree:");
            rightViewPrinter.Print();  // Expected Output: 2 5 6 7
        }
    }
}
