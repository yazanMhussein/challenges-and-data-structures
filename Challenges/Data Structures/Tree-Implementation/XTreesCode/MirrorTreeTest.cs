using System;
using System.Collections.Generic;
using Xunit;

namespace TreesCode.Tests
{
    public class MirrorTreeTests
    {
        [Fact]
        public void TestMirrorTree()
        {
            // Arrange
            BinaryTree tree = new BinaryTree(10);
            tree.Insert(5);
            tree.Insert(18);
            tree.Insert(3);
            tree.Insert(7);
            tree.Insert(15);

            List<int> expectedInOrderBefore = new List<int> { 3, 5, 7, 10, 15, 18 };
            List<int> expectedInOrderAfter = new List<int> { 18, 15, 10, 7, 5, 3 };

            // Act
            List<int> inOrderBefore = new List<int>();
            InOrderTraversal(tree.Root, inOrderBefore);

            MirrorTree.ConvertToMirror(tree);

            List<int> inOrderAfter = new List<int>();
            InOrderTraversal(tree.Root, inOrderAfter);

            // Assert
            Assert.Equal(expectedInOrderBefore, inOrderBefore);
            Assert.Equal(expectedInOrderAfter, inOrderAfter);
        }

        private void InOrderTraversal(TNode node, List<int> result)
        {
            if (node == null) return;
            InOrderTraversal(node.Left, result);
            result.Add(node.Value);
            InOrderTraversal(node.Right, result);
        }
    }
}
