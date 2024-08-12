using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreesCode;

namespace XTreesCode
{
    public class BinaryTreeTest
        {
        [Fact]
        public void TestPreOrderTraversal()
        {
            var tree = new BinaryTree(10);
            tree.Insert(5);
            tree.Insert(18);
            tree.Insert(3);
            tree.Insert(7);
            tree.Insert(15);

            var output = new StringBuilder();
            using (var sw = new StringWriter(output))
            {
                Console.SetOut(sw);
                tree.PreOrderTraversal(tree.Root);
            }

            Assert.Equal("10 5 3 7 18 15 ", output.ToString().Trim());
        }

        [Fact]
        public void TestInOrderTraversal()
        {
            var tree = new BinaryTree(10);
            tree.Insert(5);
            tree.Insert(18);
            tree.Insert(3);
            tree.Insert(7);
            tree.Insert(15);

            var output = new StringBuilder();
            using (var sw = new StringWriter(output))
            {
                Console.SetOut(sw);
                tree.InOrderTraversal(tree.Root);
            }

            Assert.Equal("3 5 7 10 15 18 ", output.ToString().Trim());
        }

        [Fact]
        public void TestPostOrderTraversal()
        {
            var tree = new BinaryTree(10);
            tree.Insert(5);
            tree.Insert(18);
            tree.Insert(3);
            tree.Insert(7);
            tree.Insert(15);

            var output = new StringBuilder();
            using (var sw = new StringWriter(output))
            {
                Console.SetOut(sw);
                tree.PostOrderTraversal(tree.Root);
            }

            Assert.Equal("3 7 5 15 18 10 ", output.ToString().Trim());
        }
    }
}
