using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreesCode
{
    public class BinarySearchTree : BinaryTree
    {
        public BinarySearchTree(int rootValue) : base(rootValue)
        {
        }

        public void Add(int data)
        {
            Root = Add(Root, data);
        }

        private TNode Add(TNode node, int data)
        {
            if (node == null)
                return new TNode(data);

            if (data < node.Value)
                node.Left = Add(node.Left, data);
            else
                node.Right = Add(node.Right, data);

            return node;
        }

        public bool Contains(int data)
        {
            return Contains(Root, data);
        }

        private bool Contains(TNode node, int data)
        {
            if (node == null)
                return false;

            if (data == node.Value)
                return true;

            return data < node.Value ? Contains(node.Left, data) : Contains(node.Right, data);
        }

        public void Remove(int data)
        {
            Root = Remove(Root, data);
        }

        private TNode Remove(TNode node, int data)
        {
            if (node == null)
                return null;

            if (data < node.Value)
                node.Left = Remove(node.Left, data);
            else if (data > node.Value)
                node.Right = Remove(node.Right, data);
            else
            {
                if (node.Left == null)
                    return node.Right;
                else if (node.Right == null)
                    return node.Left;

                node.Value = MinValue(node.Right);
                node.Right = Remove(node.Right, node.Value);
            }

            return node;
        }

        private int MinValue(TNode node)
        {
            int minvalue = node.Value;
            while (node.Left != null)
            {
                minvalue = node.Left.Value;
                node = node.Left;
            }
            return minvalue;
        }
    }
}
