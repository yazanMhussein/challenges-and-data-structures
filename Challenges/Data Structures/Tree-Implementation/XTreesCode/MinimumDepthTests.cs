using Xunit;
using TreesCode;

namespace TreesCode.Tests
{
    public class MinimumDepthTests
    {
        [Fact]
        public void FindMinimumDepth_MultipleNodes_ShouldReturnCorrectDepth()
        {
            // Arrange
            BinaryTree Btree = new BinaryTree(1);
            Btree.Root.Left = new TNode(2);
            Btree.Root.Right = new TNode(3);
            Btree.Root.Left.Left = new TNode(4);
            Btree.Root.Left.Right = new TNode(5);

            MinimumDepth minDepthFinder = new MinimumDepth();

            // Act
            int result = minDepthFinder.FindMinimumDepth(Btree.Root);

            // Assert
            Assert.Equal(2, result);
        }

        [Fact]
        public void FindMinimumDepth_EmptyTree_ShouldReturnZero()
        {
            // Arrange
            BinaryTree emptyTree = new BinaryTree(0);
            emptyTree.Root = null; // Simulate empty tree

            MinimumDepth minDepthFinder = new MinimumDepth();

            // Act
            int result = minDepthFinder.FindMinimumDepth(emptyTree.Root);

            // Assert
            Assert.Equal(0, result);
        }

        [Fact]
        public void FindMinimumDepth_OneNode_ShouldReturnOne()
        {
            // Arrange
            BinaryTree singleNodeTree = new BinaryTree(1);

            MinimumDepth minDepthFinder = new MinimumDepth();

            // Act
            int result = minDepthFinder.FindMinimumDepth(singleNodeTree.Root);

            // Assert
            Assert.Equal(1, result);
        }
    }
}
