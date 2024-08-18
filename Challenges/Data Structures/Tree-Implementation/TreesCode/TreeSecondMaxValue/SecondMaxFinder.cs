using System;

namespace TreesCode.TreeSecondMaxValue
{
    public class SecondMaxFinder
    {
        public int FindSecondMax(TNode root)
        {
            if (root == null)
            {
                throw new InvalidOperationException("Tree is empty.");
            }

            int maxValue = int.MinValue;
            int secondMaxValue = int.MinValue;
            bool foundSecondMax = false;

            void Traverse(TNode node)
            {
                if (node == null) return;

                // Traverse the left subtree
                Traverse(node.Left);

                // Update max and second max values
                if (node.Value > maxValue)
                {
                    secondMaxValue = maxValue;
                    maxValue = node.Value;
                    foundSecondMax = true;
                }
                else if (node.Value < maxValue && node.Value > secondMaxValue)
                {
                    secondMaxValue = node.Value;
                    foundSecondMax = true;
                }

                // Traverse the right subtree
                Traverse(node.Right);
            }

            Traverse(root);

            if (!foundSecondMax || secondMaxValue == int.MinValue)
            {
                throw new InvalidOperationException("Tree does not have a second maximum value.");
            }

            return secondMaxValue;
        }
    }
}
