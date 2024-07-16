using System;

namespace LinkedList
{
    public class LinkedList
    {
        public Node head;

        public void InsertToHead(Node current)
        {
            current.Next = head;
            head = current;
        }

        public void InsertEnd(Node current)
        {
            Node node = head;
            if (node == null)
            {
                InsertToHead(current);
                return;
            }
            while (node.Next != null)
            {
                node = node.Next;
            }

            node.Next = current;
            current.Next = null;
        }

        public bool Includes(int data)
        {
            Node current = head;
            while (current != null)
            {
                if (current.Data == data)
                {
                    return true;
                }
                current = current.Next;
            }
            return false;
        }

        public void Remove(int data)
        {
            if (head == null) return;

            if (head.Data == data)
            {
                head = head.Next;
                return;
            }

            Node current = head;
            while (current.Next != null)
            {
                if (current.Next.Data == data)
                {
                    current.Next = current.Next.Next;
                    return;
                }
                current = current.Next;
            }
        }

        public void PrintList()
        {
            Node current = head;
            if (head == null)
            {
                Console.WriteLine("Linked list is empty");
            }
            else
            {
                while (current != null)
                {
                    Console.WriteLine(current.Data);
                    current = current.Next;
                }
            }
        }
    }
}
