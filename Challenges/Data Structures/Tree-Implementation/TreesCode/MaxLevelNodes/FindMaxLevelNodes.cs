using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using TreesCode;
namespace MaxLevelNodes
{
    public class FindMaxLevelNodes
    {
            public int FindMaxLevelNode(TNode root)
           {
            if (root == null) { throw new InvalidOperationException("The tree is empty."); }
            Queue<TNode> queue = new Queue<TNode>();
                queue.Enqueue(root);
                int level = 0;
                int maxLevel = 0;
                int maxNodes = 0;
                while (queue.Count > 0)
                {
                    int levelNodeCount = queue.Count;
                    if (levelNodeCount > maxNodes)
                    {
                        maxNodes = levelNodeCount;
                        maxLevel = level;
                    }
                    for (int i = 0; i < levelNodeCount; i++)
                    {
                        TNode currentNode = queue.Dequeue();
                        if (currentNode.Left != null)
                        {
                            queue.Enqueue(currentNode.Left);
                        }
                        if (currentNode.Right != null)
                        {
                            queue.Enqueue(currentNode.Right);}}
                            level++;}
                        return maxLevel;}}}