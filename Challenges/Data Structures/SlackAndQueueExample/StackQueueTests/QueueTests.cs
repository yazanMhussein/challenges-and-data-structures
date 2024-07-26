using Xunit;
using Stack_QueueExample;

public class QueueTests
{
    [Fact]
    public void TestEnqueue()
    {
        var queue = new QueueExample();
        queue.Enqueue(1);
        Assert.Equal(1, queue.Peek());
    }

    [Fact]
    public void TestDequeue()
    {
        var queue = new QueueExample();
        queue.Enqueue(1);
        queue.Enqueue(2);
        int dequeuedValue = queue.Dequeue();
        Assert.Equal(1, dequeuedValue);
        Assert.Equal(2, queue.Peek());
    }

    [Fact]
    public void TestIsEmpty()
    {
        var queue = new QueueExample();
        Assert.True(queue.IsEmpty());
        queue.Enqueue(1);
        Assert.False(queue.IsEmpty());
        queue.Dequeue();
        Assert.True(queue.IsEmpty());
    }
}
