using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreesCode;

namespace XTreesCode
{
    public class BinarySearchTreeTest
    {
        [Fact]
        public void TestAdd()
        {
            var bst = new BinarySearchTree(10);
            bst.Add(5);
            bst.Add(18);
            bst.Add(3);
            bst.Add(7);
            bst.Add(15);

            var output = new StringBuilder();
            using (var sw = new StringWriter(output))
            {
                Console.SetOut(sw);
                bst.InOrderTraversal(bst.Root);
            }

            Assert.Equal("3 5 7 10 15 18 ", output.ToString().Trim());
        }

        [Fact]
        public void TestContains()
        {
            var bst = new BinarySearchTree(10);
            bst.Add(5);
            bst.Add(18);
            bst.Add(3);
            bst.Add(7);
            bst.Add(15);

            Assert.True(bst.Contains(7));
            Assert.False(bst.Contains(20));
        }

        [Fact]
        public void TestRemove()
        {
            var bst = new BinarySearchTree(10);
            bst.Add(5);
            bst.Add(18);
            bst.Add(3);
            bst.Add(7);
            bst.Add(15);

            bst.Remove(7);

            var output = new StringBuilder();
            using (var sw = new StringWriter(output))
            {
                Console.SetOut(sw);
                bst.InOrderTraversal(bst.Root);
            }

            Assert.Equal("3 5 10 15 18 ", output.ToString().Trim());
        }
    }
}
