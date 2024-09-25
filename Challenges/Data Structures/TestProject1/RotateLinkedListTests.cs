using Xunit;

namespace LinkedList.Tests
{
    public class RotateLinkedListTests
    {
        [Fact]
        public void RotateLeft_WhenKIsZero_ListRemainsUnchanged()
        {
            // Arrange
            LinkedList list = new LinkedList();
            list.InsertEnd(new Node(1));
            list.InsertEnd(new Node(2));
            list.InsertEnd(new Node(3));
            list.InsertEnd(new Node(4));

            RotateLinkedList rotator = new RotateLinkedList();

            // Act
            rotator.RotateLeft(list, 0);

            // Assert
            Assert.Equal("Head -> 1 -> 2 -> 3 -> 4 -> Null", GetListString(list));
        }

        [Fact]
        public void RotateLeft_WhenKIsGreaterThanListLength_RotatesCorrectly()
        {
            // Arrange
            LinkedList list = new LinkedList();
            list.InsertEnd(new Node(1));
            list.InsertEnd(new Node(2));
            list.InsertEnd(new Node(3));
            list.InsertEnd(new Node(4));

            RotateLinkedList rotator = new RotateLinkedList();

            // Act
            rotator.RotateLeft(list, 7);  // 7 is greater than the list length (4)

            // Assert
            Assert.Equal("Head -> 4 -> 1 -> 2 -> 3 -> Null", GetListString(list));
        }

        private string GetListString(LinkedList list)
        {
            Node? current = list.head;
            if (current == null)
            {
                return "Head -> Null";
            }

            string result = "Head -> ";
            while (current != null)
            {
                result += current.Data;
                if (current.Next != null)
                {
                    result += " -> ";
                }
                current = current.Next;
            }
            result += " -> Null";

            return result;
        }
    }
}
