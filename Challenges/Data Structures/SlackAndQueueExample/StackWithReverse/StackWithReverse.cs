using System;
using System.Collections.Generic;

namespace Slack_QueueExample;

public class StackWithReverse : StackExample
{
    public void ReverseStack()
    {
        Queue<int> queue = new Queue<int>();

        
        while (!IsEmpty())
        {
            queue.Enqueue(Pop());
        }

        
        while (queue.Count > 0)
        {
            Push(queue.Dequeue());
        }
    }

    public override string ToString()
    {
        List<int> elements = new List<int>();
        Node? current = top;
        while (current != null)
        {
            elements.Add(current.Data);
            current = current.Next;
        }

        elements.Reverse();
        return "Stack: [" + string.Join(" , ", elements) + "]";
    }
}
