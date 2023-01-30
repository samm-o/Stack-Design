using System;
using System.Collections.Generic;

namespace Stack_Design
{
    public class Stack
    {
        private readonly List<object> stack = new List<object>();

        public void Push(object obj)
        {
            if (obj != null)
            {
                stack.Insert(0, obj);
            }
            else
            {
                Console.WriteLine("Null cannot be passed into the stack.");
                Environment.Exit(0);
            }
        }

        public object Pop()
        {
            object returnValue = null;

            try
            {
                var removed = stack[0];
                stack.RemoveAt(0);
                returnValue = removed;
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Cannot remove element from an empty list.");
            }

            return returnValue;
        }
        public void Clear()
        {
            stack.Clear();
        }
    }
}
