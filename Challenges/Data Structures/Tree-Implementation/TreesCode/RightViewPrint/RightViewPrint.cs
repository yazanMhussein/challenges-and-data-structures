using System;
using System.Collections.Generic;
using TreesCode;

namespace RightViewPrint
{
    public class PrintRightView
    {
        private BinaryTree tree;

        // Constructor that takes in a BinaryTree object
        public PrintRightView(BinaryTree tree)
        {
            this.tree = tree;
        }

        // Method to print the right view of the binary tree
        public void Print()
        {
            if (tree.Root == null)
            {
                Console.WriteLine("The tree is empty.");
                return;
            }

            Queue<TNode> queue = new Queue<TNode>(); // Use TNode from TreesCode
            queue.Enqueue(tree.Root);

            while (queue.Count > 0)
            {
                int levelSize = queue.Count;
                TNode rightMostNode = null;

                // Process nodes at the current level
                for (int i = 0; i < levelSize; i++)
                {
                    TNode currentNode = queue.Dequeue();

                    // Update the rightMostNode with the current node at this level
                    rightMostNode = currentNode;

                    // Enqueue the left and right children
                    if (currentNode.Left != null)
                    {
                        queue.Enqueue(currentNode.Left);
                    }
                    if (currentNode.Right != null)
                    {
                        queue.Enqueue(currentNode.Right);
                    }
                }

                // Print the rightmost node of this level
                if (rightMostNode != null)
                {
                    Console.Write(rightMostNode.Value + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
