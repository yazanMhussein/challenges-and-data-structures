using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using TreesCode;

public class MinimumDepth
{
   public int FindMinimumDepth(TNode root)
{
    if (root == null)
    {
        return 0; // Empty tree
    }

    Queue<TNode> queue = new Queue<TNode>();
    queue.Enqueue(root);
    int depth = 1;

    while (queue.Count > 0)
    {
        int levelNodeCount = queue.Count;

        for (int i = 0; i < levelNodeCount; i++)
        {
            TNode currentNode = queue.Dequeue();

            // If we reach a leaf node, return the current depth
            if (currentNode.Left == null && currentNode.Right == null)
            {
                return depth;
            }

            if (currentNode.Left != null)
            {
                queue.Enqueue(currentNode.Left);
            }

            if (currentNode.Right != null)
            {
                queue.Enqueue(currentNode.Right);
            }
        }

        depth++;
    }

    return depth;
}
}

