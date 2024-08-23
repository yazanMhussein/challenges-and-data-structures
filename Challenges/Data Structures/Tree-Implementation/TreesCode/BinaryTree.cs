﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreesCode
{
    public class BinaryTree
    {
        public TNode Root { get; set; }


        public BinaryTree(int rootValue)
        {
            Root = new TNode(rootValue);
        }


        public void Insert(int value)
        {
            Insert(Root, value);
        }

        private void Insert(TNode node, int value)
        {
            if (value < node.Value)
            {
                if (node.Left == null)
                {
                    node.Left = new TNode(value);
                }
                else
                {
                    Insert(node.Left, value);
                }
            }

            else
            {
                if (node.Right == null)
                {
                    node.Right = new TNode(value);
                }
                else
                {
                    Insert(node.Right, value);
                }
            }
        }

        // ( Root - Left - Right )
        public void PreOrderTraversal(TNode node)
        {
            if (node == null) return; // Base case if node null then return

            Console.Write(node.Value + "  ");
            PreOrderTraversal(node.Left);
            PreOrderTraversal(node.Right);

        }

        // ( Left - Root - right )
        public void InOrderTraversal(TNode node)
        {
            if (node == null) return;

            InOrderTraversal(node.Left);
            Console.Write(node.Value + "  ");
            InOrderTraversal(node.Right);

        }

        // ( Left - Right - Root )
        public void PostOrderTraversal(TNode node)
        {
            if (node == null) return; // Base case if node is null then return
            PostOrderTraversal(node.Left);
            PostOrderTraversal(node.Right);
            Console.WriteLine(node.Value + " ");
        }
        public void Print(TNode node, string indent = "", bool last = true)
        {
            if (node != null)
            {
                Console.Write(indent);
                if (last)
                {
                    Console.Write("└─");
                    indent += "  ";
                }
                else
                {
                    Console.Write("├─");
                    indent += "| ";
                }
                Console.WriteLine(node.Value);

                Print(node.Left, indent, false);
                Print(node.Right, indent, true);
            }
        }

        public int LeafSum()
        {
            if (Root == null)
            {
                throw new InvalidOperationException("Tree is empty.");
            }

            return SumOfLeafNodes(Root);
        }
        private int SumOfLeafNodes(TNode node)
        {
            if (node == null)
            {
                return 0;
            }
            if (node.Left == null && node.Right == null)
            {
                return node.Value;
            }
            return SumOfLeafNodes(node.Left) + SumOfLeafNodes(node.Right);
        }
    }
}
 