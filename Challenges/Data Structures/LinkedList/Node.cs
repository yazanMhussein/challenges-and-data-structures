using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using namespace LinkedList
{
    public class Node
    {
        public int Data;
        public Node Next;

        public Node(int data, Node next) {
            Data = data;
            Next = next;    
        }
    }
}