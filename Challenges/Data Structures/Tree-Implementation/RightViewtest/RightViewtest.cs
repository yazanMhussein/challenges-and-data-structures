using RightViewPrint;
using System;
using System.IO;
using System.Xml.Linq;
using Xunit;

namespace TreesCode.Tests
{
    public class RightViewTest
    {
        [Fact]
        public void Test_RightView_Prints_Correctly()
        {
            // Arrange
            var tree = new BinaryTree
            {
                Root = new Node(2)
            };
            tree.Root.Left = new Node(3);
            tree.Root.Right = new Node(5);
            tree.Root.Left.Left = new Node(4);
            tree.Root.Right.Right = new Node(6);
            tree.Root.Left.Left.Right = new Node(7);

            // Redirect console output to a StringWriter
            using var sw = new StringWriter();
            Console.SetOut(sw);

            // Act
            PrintRightView.PrintRightView(tree);  // Call the method to test

            // Assert
            var expectedOutput = "Right view of the binary tree:\n2 5 6 7\n";
            Assert.Equal(expectedOutput, sw.ToString());
        }

        [Fact]
        public void Test_RightView_Prints_Correctly_Right_Only_Tree()
        {
            // Arrange
            var tree = new BinaryTree
            {
                Root = new Node(1)
            };
            tree.Root.Right = new Node(2);
            tree.Root.Right.Right = new Node(3);
            tree.Root.Right.Right.Right = new Node(4);

            // Redirect console output to a StringWriter
            using var sw = new StringWriter();
            Console.SetOut(sw);

            // Act
            PrintRightView.PrintRightView(tree);  // Call the method to test

            // Assert
            var expectedOutput = "Right view of the binary tree:\n1 2 3 4\n";
            Assert.Equal(expectedOutput, sw.ToString());
        }
    }
}
