
namespace LinkedList
{
    public class RotateLinkedList
    {
        public void RotateLeft(LinkedList linkedList, int k)
        {
            if (linkedList.head == null || linkedList.head.Next == null || k == 0)
            {
                Console.WriteLine("No rotation needed.");
                return; // No rotation needed
            }

            // Step 1: Calculate the length of the linked list
            Node? current = linkedList.head;
            int length = 1;
            while (current.Next != null)
            {
                current = current.Next;
                length++;
            }

            // Step 2: Make the linked list circular by connecting the last node to the head
            current.Next = linkedList.head;

            // Step 3: Calculate the effective rotations needed
            k = k % length;
            if (k == 0) 
            {
                current.Next = null;
                return;
            }

            // Step 4: Traverse to the new tail node (k steps from the head)
            current = linkedList.head;
            for (int i = 1; i < k; i++)
            {
                current = current.Next;
            }

            // Step 5: Set the new head and break the circular link
            Node? newHead = current.Next;
            current.Next = null;
            linkedList.head = newHead;
        }
        
    }
}