using Slack_QueueExample;
using System;

namespace Slack_QueueExample;
public class StackExample
{
    private Node top;// top is the stack
    public StackExample()
    {
        top = null;// the stack is empty becasues its null
    }
    // methods
    public void Push(int data)
    {
        Node newNode = new Node(data);
        newNode.Next = top;
        top = newNode;
    }
    public int Pop()
    {
        if (IsEmpty())
        {
            throw new Exception("Stacck is Empty");
        }
        int data = top.Data;
        top = top.Next;
        return data;
    }
    public int Peek()
    {
        if (IsEmpty())
        {
            throw new Exception("Stack is Empty");
        }
        return top.Data;
    }
    public bool IsEmpty()
    {
        return top == null;
    }
}
}
 