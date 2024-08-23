using System.Xml.Linq;

namespace TreeTest
{
    public class BinaryTreeTests
    {
        [Fact]
        public void LeafSum_ShouldReturnCorrectSum_ForGivenTree()
        {
            // Arrange
            var tree = new BinaryTree(9);
            tree.Root.Left = new TNode(8);
            tree.Root.Right = new TNode(12);
            tree.Root.Left.Left = new TNode(3);
            tree.Root.Left.Right = new TNode(7);
            tree.Root.Right.Left = new TNode(17);
            tree.Root.Right.Right = new TNode(23);
            tree.Root.Left.Left.Right = new TNode(4);

            // Act
            int result = tree.LeafSum();

            // Assert
            Assert.Equal(51, result);
        }

        [Fact]
        public void LeafSum_ShouldReturnCorrectSum_ForTreeWithNegativeLeafValues()
        {
            // Arrange
            var tree = new BinaryTree(-10);
            tree.Root.Left = new TNode(-5);
            tree.Root.Right = new TNode(-15);
            tree.Root.Left.Left = new TNode(-3);
            tree.Root.Left.Right = new TNode(-7);
            tree.Root.Right.Left = new TNode(-20);
            tree.Root.Right.Right = new TNode(-25);
            tree.Root.Left.Left.Right = new TNode(-2);

            // Act
            int result = tree.LeafSum();

            // Assert
            Assert.Equal(-54, result); // -2 + (-7) + (-20) + (-25) = -54
        }
    }
}
