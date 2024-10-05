using MaxLevelNodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreesCode;

namespace MaxLevelNodesTest
{ 
    public class FindMaxLevelNodeTest
    {
        [Fact]
        public void Test_FindMaxLevelNode_CorrectLevelWithMaximumNodes()
        {
            // Arrange
            var binaryTree = new BinaryTree(1);
            binaryTree.Insert(2);
            binaryTree.Insert(3);
            binaryTree.Insert(4);
            binaryTree.Insert(5);
            binaryTree.Insert(6);
            binaryTree.Insert(7);

            // Act
            var finder = new FindMaxLevelNodes(binaryTree);
            int result = finder.FindMaxLevelNode();

            // Assert
            Assert.Equal(2, result); // Level 2 has the maximum nodes (4, 5, 6)
        }

        [Fact]
        public void Test_FindMaxLevelNode_MultipleLevelsSameMaxNodes()
        {
            // Arrange
            var binaryTree = new BinaryTree(1);
            binaryTree.Insert(2);
            binaryTree.Insert(3);
            binaryTree.Insert(4);
            binaryTree.Insert(5);
            binaryTree.Insert(6);
            binaryTree.Insert(7);
            binaryTree.Insert(8); // Adding more nodes to create a tree with equal nodes on different levels.

            // Act
            var finder = new FindMaxLevelNodes(binaryTree);
            int result = finder.FindMaxLevelNode();

            // Assert
            Assert.Equal(1, result); // Both level 1 (2, 3) and level 2 (4, 5, 6, 7) have the same max nodes, but we return the lower level
        }

        [Fact]
        public void Test_FindMaxLevelNode_EmptyTree()
        {
            // Arrange
            var binaryTree = new BinaryTree(0);

            // Act
            var finder = new FindMaxLevelNodes(binaryTree);

            // Assert
            Assert.Throws<Exception>(() => finder.FindMaxLevelNode());
        }
    }
}
