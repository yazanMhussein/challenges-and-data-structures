using Stack_Queue;
using System;

namespace Slack_QueueExample;
public class QueueExample
{
    private Node front;
    private Node back;

    public QueueExample()
    {
        front = back = null;
    }
    public void Enqueue(int data)
    {
        Node newNode = new Node(data);

        // check if the queue is empty
        if (back == null)
        {
            front = back = newNode;
        }
        else
        {
            back.Next = newNode;
            back = newNode;
        }
    }
    public int Peek()
    {
        if (IsEmpty())
        {

            throw new Exception("the queue is empty peek");
        }
        return front.Data;
    }
    public int Dequeue()
    {
        if (IsEmpty())
        {
            throw new Exception("the queue is empty dequeue");

        }
        int data = front.Data;
        front = front.Next;
        if (front == null)
        {
            back = null;
        }
        return data;
    }
    public bool IsEmpty()
    {
        return front == null;
    }
}
