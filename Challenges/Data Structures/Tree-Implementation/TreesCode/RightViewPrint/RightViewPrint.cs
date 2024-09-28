using System;
using System.Collections.Generic;
using TreesCode;

namespace RightViewPrint
{
    public class PrintRightView
    {
        private BinaryTree tree;

        public PrintRightView(BinaryTree tree)
        {
            this.tree = tree;
        }

       
        public void Print()
        {
            if (tree.Root == null)
            {
                Console.WriteLine("The tree is empty.");
                return;
            }

            Queue<TNode> queue = new Queue<TNode>();
            queue.Enqueue(tree.Root);

            while (queue.Count > 0)
            {
                int levelSize = queue.Count;
                TNode rightMostNode = null;

                
                for (int i = 0; i < levelSize; i++)
                {
                    TNode currentNode = queue.Dequeue();

                   
                    rightMostNode = currentNode;

                   
                    if (currentNode.Left != null)
                    {
                        queue.Enqueue(currentNode.Left);
                    }
                    if (currentNode.Right != null)
                    {
                        queue.Enqueue(currentNode.Right);
                    }
                }

               
                if (rightMostNode != null)
                {
                    Console.Write(rightMostNode.Value + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
