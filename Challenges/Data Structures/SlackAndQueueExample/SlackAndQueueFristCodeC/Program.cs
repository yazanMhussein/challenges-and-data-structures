using Stack_Queue;
namespace Slack_QueueExample;
public class Program
{   static void Main(string[] args){
            var stack = new StackWithDeleteMiddle();
            InitializeStack(stack);
            DisplayStackOperation(stack, "Original Stack:");
            stack.DeleteMiddle();
            DisplayStackOperation(stack, "After Deleting Middle Element:");
            stack.Push(2);
            stack.Push(9);
            stack.Push(11);
            DisplayStackOperation(stack, "After Pushing More Elements:");
            stack.DeleteMiddle();
            DisplayStackOperation(stack, "After Deleting Middle Element Again:");
    }
    static void InitializeStack(StackWithDeleteMiddle stack) => 
    new int[] { 7, 14, 3, 8, 5 }.ToList().ForEach(stack.Push);
    static void DisplayStackOperation(StackExample stack, string message)
        { Console.WriteLine(message); PrintStack(stack); }
        static void PrintStack(StackExample stack)
        {   var tempStack = new StackExample();
            while (!stack.IsEmpty()) tempStack.Push(stack.Pop());
            while (!tempStack.IsEmpty()) Console.Write($"{stack.Push(tempStack.Pop())} ");
            Console.WriteLine();}}}}}}
