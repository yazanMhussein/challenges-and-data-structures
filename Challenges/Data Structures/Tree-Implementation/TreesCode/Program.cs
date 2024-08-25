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
            BinaryTree Btree = new BinaryTree(5);
            Btree.Root.Left = new TNode(13);
            Btree.Root.Right = new TNode(7);
            Btree.Root.Left.Left = new TNode(3);
            Btree.Root.Left.Right = new TNode(7);
            Btree.Root.Right.Left = new TNode(12);
            Btree.Root.Right.Right = new TNode(20);
            Btree.Root.Left.Left.Left = new TNode(1);
            Btree.Root.Left.Left.Right = new TNode(4);
            Btree.Root.Right.Left.Right = new TNode(11);

            List<int> largestValues = Btree.LargestLevelValue();
            Console.WriteLine("Largest values at each level: " + string.Join(", ", largestValues));
            
        }
    }
}
