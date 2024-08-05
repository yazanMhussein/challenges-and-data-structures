namespace XDeleteMidEle
{
    public class DeleteMiddleElement 
    {
        [Fact]
        public void DeleteMiddle_OddSizedStack_DeletesMiddleElement()
        {
            // Arrange
            StackWithDeleteMiddle stack = new StackWithDeleteMiddle();
            stack.Push(7);
            stack.Push(14);
            stack.Push(3);
            stack.Push(8);
            stack.Push(5);

            // Act
            stack.DeleteMiddle();

            // Assert
            Assert.Equal(5, stack.Pop());
            Assert.Equal(8, stack.Pop());
            Assert.Equal(14, stack.Pop());
            Assert.Equal(7, stack.Pop());
        }

        [Fact]
        public void DeleteMiddle_EvenSizedStack_DeletesLowerMiddleElement()
        {
            // Arrange
            StackWithDeleteMiddle stack = new StackWithDeleteMiddle();
            stack.Push(7);
            stack.Push(14);
            stack.Push(3);
            stack.Push(8);
            stack.Push(5);
            stack.Push(10);

            // Act
            stack.DeleteMiddle();

            // Assert
            Assert.Equal(10, stack.Pop());
            Assert.Equal(5, stack.Pop());
            Assert.Equal(14, stack.Pop());
            Assert.Equal(7, stack.Pop());
        }

        [Fact]
        public void DeleteMiddle_EmptyStack_ThrowsException()
        {
            // Arrange
            StackWithDeleteMiddle stack = new StackWithDeleteMiddle();

            // Act & Assert
            Assert.Throws<Exception>(() => stack.DeleteMiddle());
        }

        [Fact]
        public void DeleteMiddle_OneElementStack_LeavesStackEmpty()
        {
            // Arrange
            StackWithDeleteMiddle stack = new StackWithDeleteMiddle();
            stack.Push(1);

            // Act
            stack.DeleteMiddle();

            // Assert
            Assert.True(stack.IsEmpty());
        }
    }
}