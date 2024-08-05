using System;

namespace Slack_QueueExample{
    public int DeleteMiddle()
    {   if (IsEmpty()) { throw new InvalidOperationException("Stack is empty."); }
        int count = GetStackCount(); if (count == 1)
        { top = null; return; }
        int middleIndex = count / 2; RemoveMiddleElement(middleIndex); }
    private int GetStackCount()
    {   int count = 0; Node current = top;
        while (current != null) { count++; current = current.Next; }
        return count; }
    private void RemoveMiddleElement(int middleIndex)
    {   StackExample tempStack = new StackExample();
        for (int i = 0; i < middleIndex; i++) { tempStack.Push(Pop()); }
        Pop(); while (!tempStack.IsEmpty()) { Push(tempStack.Pop()); }}}}
