using System;
using Xunit;
using System;
using Stack_Queue;
namespace Slack_QueueExample;
namespace XMinStack
{
    public class StackExampleTests
    {
        [Fact]
        public void DeleteMiddle_ShouldRemoveMiddleElement_WhenStackHasOddNumberOfElements()
        {
            // Arrange
            StackExample stack = new StackExample();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5); // Stack is now: 5 -> 4 -> 3 -> 2 -> 1

            // Act
            stack.DeleteMiddle(); // Middle element '3' should be removed

            // Assert
            Assert.Equal(5, stack.Pop());
            Assert.Equal(4, stack.Pop());
            Assert.Equal(2, stack.Pop());
            Assert.Equal(1, stack.Pop());
            Assert.True(stack.IsEmpty());
        }

        [Fact]
        public void DeleteMiddle_ShouldRemoveMiddleElement_WhenStackHasEvenNumberOfElements()
        {
            // Arrange
            StackExample stack = new StackExample();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4); // Stack is now: 4 -> 3 -> 2 -> 1

            // Act
            stack.DeleteMiddle(); // Middle element '3' should be removed

            // Assert
            Assert.Equal(4, stack.Pop());
            Assert.Equal(2, stack.Pop());
            Assert.Equal(1, stack.Pop());
            Assert.True(stack.IsEmpty());
        }

        [Fact]
        public void DeleteMiddle_ShouldHandleSingleElementStack()
        {
            // Arrange
            StackExample stack = new StackExample();
            stack.Push(1); // Stack is now: 1

            // Act
            stack.DeleteMiddle(); // Stack should become empty

            // Assert
            Assert.True(stack.IsEmpty());
        }

        [Fact]
        public void DeleteMiddle_ShouldThrowException_WhenStackIsEmpty()
        {
            // Arrange
            StackExample stack = new StackExample();

            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => stack.DeleteMiddle());
        }
    }
}
