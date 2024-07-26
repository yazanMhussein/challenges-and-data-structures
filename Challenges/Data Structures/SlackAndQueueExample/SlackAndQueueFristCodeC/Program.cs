using Stack_Queue;

namespace Slack_QueueExample;

public class Program
{
    static void Main(string[] args)
    {
        StackExample stack = new StackExample();
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);
        stack.Push(4);
        stack.Push(5);
        stack.Pop();
        try
        {
            Console.WriteLine("The stack value is " + stack.Peek());
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        Console.WriteLine();

        Console.WriteLine();
        QueueExample queue = new QueueExample();
        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);
        queue.Enqueue(4);
        queue.Dequeue();
        queue.Dequeue();
        queue.Dequeue();
        queue.Dequeue();
        try
        {
            Console.WriteLine("The queue value is " + queue.Peek());
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
