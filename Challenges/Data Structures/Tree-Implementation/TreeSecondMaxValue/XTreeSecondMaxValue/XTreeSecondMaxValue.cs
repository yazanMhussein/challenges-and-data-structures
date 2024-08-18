using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreesCode.Tests
{
    public class XTreeSecondMaxValue
    {
        public class BinaryTreeTests
        {
            [Fact]
            public void TestFindSecondMax_WithMultipleNodes_ReturnsSecondMax()
            {
                // Arrange
                BinaryTree BTree = new BinaryTree();
                BTree.Insert(10);
                BTree.Insert(5);
                BTree.Insert(20);
                BTree.Insert(3);
                BTree.Insert(7);
                BTree.Insert(15);
                BTree.Insert(25);

                // Act
                int? secondMax = BTree.FindSecondMax();

                // Assert
                Assert.Equal(20, secondMax);
            }

            [Fact]
            public void TestFindSecondMax_WithSingleNode_ReturnsNull()
            {
                // Arrange
                BinaryTree BTree = new BinaryTree();
                BTree.Insert(10);

                // Act & Assert
                Assert.Throws<InvalidOperationException>(() => BTree.FindSecondMax());
            }

            [Fact]
            public void TestFindSecondMax_WithNoNodes_ThrowsInvalidOperationException()
            {
                // Arrange
                BinaryTree BTree = new BinaryTree();

                // Act & Assert
                Assert.Throws<InvalidOperationException>(() => BTree.FindSecondMax());
            }

            [Fact]
            public void TestPreOrderTraversal()
            {
                // Arrange
                BinaryTree BTree = new BinaryTree();
                BTree.Insert(10);
                BTree.Insert(5);
                BTree.Insert(20);
                BTree.Insert(3);
                BTree.Insert(7);
                BTree.Insert(15);
                BTree.Insert(25);

                // Capture console output
                var output = new StringWriter();
                Console.SetOut(output);

                // Act
                BTree.PreOrderTraversal(BTree.Root);

                // Assert
                Assert.Equal("10  5  3  7  20  15  25  ", output.ToString());
            }

            [Fact]
            public void TestInOrderTraversal()
            {
                // Arrange
                BinaryTree BTree = new BinaryTree();
                BTree.Insert(10);
                BTree.Insert(5);
                BTree.Insert(20);
                BTree.Insert(3);
                BTree.Insert(7);
                BTree.Insert(15);
                BTree.Insert(25);

                // Capture console output
                var output = new StringWriter();
                Console.SetOut(output);

                // Act
                BTree.InOrderTraversal(BTree.Root);

                // Assert
                Assert.Equal("3  5  7  10  15  20  25  ", output.ToString());
            }

            [Fact]
            public void TestPostOrderTraversal()
            {
                // Arrange
                BinaryTree BTree = new BinaryTree();
                BTree.Insert(10);
                BTree.Insert(5);
                BTree.Insert(20);
                BTree.Insert(3);
                BTree.Insert(7);
                BTree.Insert(15);
                BTree.Insert(25);

                // Capture console output
                var output = new StringWriter();
                Console.SetOut(output);

                // Act
                BTree.PostOrderTraversal(BTree.Root);

                // Assert
                Assert.Equal("3  7  5  15  25  20  10 ", output.ToString().Replace("\n", " ").Replace("\r", ""));
            }
        }
}
