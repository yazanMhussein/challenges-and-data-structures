using System.Xml.Linq;
using System;
using LinkedList;
using System.Collections.Generic;
namespace LinkedList
{
    public class Program
    {
        public static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList();
            linkedList.InsertEnd(new Node(1));
            linkedList.InsertEnd(new Node(2));
            linkedList.InsertEnd(new Node(3));
            linkedList.InsertEnd(new Node(4));
            linkedList.InsertEnd(new Node(5));
            linkedList.InsertEnd(new Node(6));
            Console.WriteLine("Input:");
            linkedList.Display();
            int k = 2;
            Console.WriteLine($", k = {k}");
            RotateLinkedList rotator = new RotateLinkedList();
            rotator.RotateLeft(linkedList, k);
            Console.WriteLine("Output:");
            linkedList.Display();
        }
    }
    }




