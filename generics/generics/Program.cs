using System;
using generics.MyGenerics;

namespace generics
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new MyStack<int>();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(5);

            try
            {
                Console.WriteLine(stack.Peek());

                Console.WriteLine(stack.Pop());
                Console.WriteLine(stack.Pop());
                Console.WriteLine(stack.Pop());

                Console.WriteLine(stack.Peek());
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("empty stack!!!");
            }

            Console.ReadKey();
        }
    }
}
