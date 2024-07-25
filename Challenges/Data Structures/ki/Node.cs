using System;
namespace Stack_Queue
    
public class Node
{
    public int Data { get; set; }
    public Node Next { get; set; }

    public Node(int data) 
    { 
        Data = data;
        Next = null;  
    }
}

