namespace LinkedList
{
    public class RotateLinkedList
    {
        public void RotateLeft(LinkedList linkedList, int k)
        {
            if (linkedList.head == null || linkedList.head.Next == null || k == 0)
            {
                Console.WriteLine("No rotation needed.");
                return; 
            }
            Node? current = linkedList.head;
            int length = 1;
            while (current.Next != null)
            {
                current = current.Next;
                length++;
            }
            current.Next = linkedList.head;
            k = k % length;
            if (k == 0) 
            {
                current.Next = null;
                return;
            }
                current = linkedList.head;
            for (int i = 1; i < k; i++)
            {
                current = current.Next;
            }
            Node? newHead = current.Next;
            current.Next = null;
            linkedList.head = newHead;
        }        
    }
}