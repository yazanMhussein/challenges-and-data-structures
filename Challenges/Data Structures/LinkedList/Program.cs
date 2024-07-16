using System;

using namespace LinkedList
{
    public class Program
    {
        public static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList();

            
            linkedList.InsertToHead(new Node(1));
            linkedList.InsertToHead(new Node(2));
            linkedList.InsertEnd(new Node(3));

            
            Console.WriteLine("Linked list contents:");
            linkedList.PrintList();

            
            Console.WriteLine("Does the linked list  include 2?");
            Console.WriteLine(linkedList.Includes(2)); 

            
            linkedList.Remove(2);

            
            Console.WriteLine("is there a 2  in the Linked list after removing 2:");
            linkedList.PrintList();
            Console.WriteLine("does the list include 2?");
        }
    }
}
