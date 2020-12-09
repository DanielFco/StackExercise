using System;

namespace StackExercise
{
    class Program
    {

        static void Main(string[] args)
        {
            Stack stack = new Stack();

            stack.Push(1);
            stack.Push(2);
            stack.Push(5);
            stack.Push(3);
            stack.Push(6);
            stack.Push(2);

            Console.WriteLine(stack.MaxValue());

            stack.Pop();
            stack.Pop();

            Console.WriteLine(stack.MaxValue());
            Console.WriteLine(stack.Peek());
        }
    }
}
