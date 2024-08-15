using System;

namespace TreesCode
{
    public class MirrorTree
    {
        public static void ConvertToMirror(BinaryTree tree)
        {
            Mirror(tree.Root);
        }

        private static void Mirror(TNode node)
        {
            if (node == null) return;

            // Swap the left and right children
            TNode temp = node.Left;
            node.Left = node.Right;
            node.Right = temp;

            // Recur for left and right subtrees
            Mirror(node.Left);
            Mirror(node.Right);
        }
    }
}
