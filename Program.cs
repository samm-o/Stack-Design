using System;

namespace Stack_Design
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack();

            stack.Push("Sam");
            stack.Push(DateTime.Now);
            stack.Push(5);

            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());

            stack.Clear();

        }
    }
}
