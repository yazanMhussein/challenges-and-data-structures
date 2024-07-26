using Xunit;
using Stack_QueueExample;

public class StackTests
{
    [Fact]
    public void TestPush()
    {
        var stack = new StackExample();
        stack.Push(1);
        Assert.Equal(1, stack.Peek());
    }

    [Fact]
    public void TestPop()
    {
        var stack = new StackExample();
        stack.Push(1);
        stack.Push(2);
        int poppedValue = stack.Pop();
        Assert.Equal(2, poppedValue);
        Assert.Equal(1, stack.Peek());
    }

    [Fact]
    public void TestIsEmpty()
    {
        var stack = new StackExample();
        Assert.True(stack.IsEmpty());
        stack.Push(1);
        Assert.False(stack.IsEmpty());
        stack.Pop();
        Assert.True(stack.IsEmpty());
    }
}
