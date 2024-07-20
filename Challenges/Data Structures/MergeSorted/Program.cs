using System;
using LinkedList_Merge_Sorted
    { 
    
public void Main(string[] args) { 
 
    
    public class LinkedList
{
    public Node Head { get; set; }

    public LinkedList()
    {
        Head = null;
    }

    
    public void Add(int value)
    {
        Node newNode = new Node(value);
        if (Head == null)
        {
            Head = newNode;
        }
        else
        {
            Node current = Head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newNode;
        }
    }

    
    public static LinkedList MergeSortedLists(LinkedList list1, LinkedList list2)
    {
        if (list1.Head == null) return list2;
        if (list2.Head == null) return list1;
        Node current1 = list1.Head;
        Node current2 = list2.Head;
        LinkedList mergedList = new LinkedList();
        Node dummy = new Node(0);
        Node currentMerged = dummy;
        
        while (current1 != null && current2 != null)
        { 
            if (current1.Value <= current2.Value){
                currentMerged.Next = current1;
                current1 = current1.Next; }
            else
            {
                currentMerged.Next = current2;
                current2 = current2.Next;
            }
            currentMerged = currentMerged.Next;
        }
        currentMerged.Next = current1 ?? current2;
        mergedList.Head = dummy.Next;
        return mergedList;
    }

    // Overriding ToString method for easy comparison in tests
    public override string ToString()
    {
        if (Head == null) return "Null";
        Node current = Head;
        string result = "";
        while (current != null)
        {
            result += current.Value + " -> ";
            current = current.Next;
        }
        result += "Null";
        return result;
    }
}
}
}