using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace TreesCode
{
    public class Program
    {
        static void Main(string[] args)
        {
            BinaryTree BTree = new BinaryTree(10);
            BTree.Insert(5);
            BTree.Insert(18);
            BTree.Insert(3);
            BTree.Insert(7);
            BTree.Insert(15);

            Console.WriteLine("Pre Order Traversal");
            BTree.PreOrderTraversal(BTree.Root);
            Console.WriteLine();

            Console.WriteLine("\nIn Order Traversal");
            BTree.InOrderTraversal(BTree.Root);
            Console.WriteLine();

            Console.WriteLine("\nPost Order Traversal");
            BTree.PostOrderTraversal(BTree.Root);
            Console.WriteLine();

            Console.WriteLine("\nTree Structure");
            BTree.Print(BTree.Root);
            Console.WriteLine();

            BinarySearchTree BSTree = new BinarySearchTree(10);
            BSTree.Add(5);
            BSTree.Add(18);
            BSTree.Add(3);
            BSTree.Add(7);
            BSTree.Add(15);

            Console.WriteLine("\nBST Pre Order Traversal");
            BSTree.PreOrderTraversal(BSTree.Root);
            Console.WriteLine();

            Console.WriteLine("\nBST In Order Traversal");
            BSTree.InOrderTraversal(BSTree.Root);
            Console.WriteLine();

            Console.WriteLine("\nBST Post Order Traversal");
            BSTree.PostOrderTraversal(BSTree.Root);
            Console.WriteLine();

            Console.WriteLine("\nBST Tree Structure");
            BSTree.Print(BSTree.Root);
            Console.WriteLine();

            Console.WriteLine($"BST Contains 7: {BSTree.Contains(7)}");
            Console.WriteLine($"BST Contains 20: {BSTree.Contains(20)}");

            BSTree.Remove(7);
            Console.WriteLine("\nBST Tree Structure After Removing 7");
            BSTree.Print(BSTree.Root);
        }
    }
}
