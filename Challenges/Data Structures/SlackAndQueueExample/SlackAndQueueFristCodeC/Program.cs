using Stack_Queue;
namespace Slack_QueueExample;
{
    public class Program
{
    static void Main(string[] args)
    {
        MinStack minStack = new MinStack();
        minStack.Push(15);
        minStack.Push(7);
        minStack.Push(12);
        minStack.Push(3);
        minStack.PrintStack();
        int min = minStack.GetMin();
        Console.WriteLine("Min: " + min);
        int popped = minStack.Pop();
        minStack.PrintStack();
        min = minStack.GetMin();
        Console.WriteLine("Min: " + min);
        int peeked = minStack.Top();
        Console.WriteLine("Top: " + peeked);
        minStack.Push(2);
        minStack.PrintStack();
        min = minStack.GetMin();
        Console.WriteLine("Min: " + min);
        bool isEmpty = minStack.IsEmpty();
        Console.WriteLine("Is stack empty? " + isEmpty);
    }
}
}
         
