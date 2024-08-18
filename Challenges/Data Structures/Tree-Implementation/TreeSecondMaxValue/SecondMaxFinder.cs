using System;

namespace TreesCode
{
    public class SecondMaxFinder
    {
        public static int? FindSecondMax(BinaryTree tree)
        {
            if (tree.Root == null)
                throw new InvalidOperationException("The tree is empty.");

            return FindSecondMax(tree.Root);
        }

        private static int? FindSecondMax(TNode node)
        {
            if (node == null)
                return null;

            // Find the maximum node
            TNode maxNode = node;
            while (maxNode.Right != null)
                maxNode = maxNode.Right;

            // Find the second maximum node
            return FindSecondMaxUtil(node, maxNode.Value);
        }

        private static int? FindSecondMaxUtil(TNode node, int maxValue)
        {
            if (node == null)
                return null;

            if (node.Value == maxValue)
            {
                // If node has left subtree, find the maximum in that subtree
                if (node.Left != null)
                    return FindMax(node.Left);

                // Otherwise, traverse the ancestors
                return null;
            }

            // Traverse the right subtree
            int? right = FindSecondMaxUtil(node.Right, maxValue);
            if (right != null)
                return right;

            // Traverse the left subtree
            return node.Value;
        }

        private static int FindMax(TNode node)
        {
            while (node.Right != null)
                node = node.Right;

            return node.Value;
        }
    }
}
