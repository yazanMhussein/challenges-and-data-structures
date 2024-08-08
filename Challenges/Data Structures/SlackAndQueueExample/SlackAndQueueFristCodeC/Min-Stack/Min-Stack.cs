﻿using System;
using Stack_Queue;
namespace Slack_QueueExample
{
    public class MinStack
    {   private Stack<int> stack;
        private Stack<int> minStack;
        public MinStack(){
            stack = new Stack<int>();
            minStack = new Stack<int>();}
        public void Push(int data)
        {   stack.Push(data);
            if (minStack.Count == 0 || data <= minStack.Peek()){
                minStack.Push(data);}}
        public int Pop()
        {if (stack.Count == 0){
            throw new InvalidOperationException("Stack is empty");}
            int popped = stack.Pop();
            if (popped == minStack.Peek())
            { minStack.Pop();}
            return popped;}
        public int Top() {
            if (stack.Count == 0)
            { throw new InvalidOperationException("Stack is empty");}
            return stack.Peek(); }
        public int GetMin()
        { if (minStack.Count == 0) {
          throw new InvalidOperationException("Stack is empty"); }
            return minStack.Peek(); }
        public bool IsEmpty(){
           return stack.Count == 0;}
        public void PrintStack(){
            Console.Write("Top -> ");
            foreach (int item in stack){Console.Write(item + " -> ");}
            Console.WriteLine("null");}}}