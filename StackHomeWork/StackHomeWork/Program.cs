using System;
using System.Collections.Generic;
using System.Linq;

namespace StackHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Get the last element of the stack(LIFO) without destroying the stack\n");

            Stack<int> myStack = new Stack<int>();
            myStack.Push(10);
            myStack.Push(12);
            myStack.Push(54);
            myStack.Push(482);
            Console.WriteLine("First method: \n");
            List<int> myList = myStack.ToList();
            var lastElem = myList.LastOrDefault();
            Console.WriteLine($"The last element of the stack is {lastElem}");
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine("Second method: \n");
            Console.WriteLine("At the begining:  ");
            foreach (var elem in myStack)
            {
                Console.WriteLine(elem);
            }

            var last = myStack.LastOrDefault();

            Console.WriteLine("\nThe last element of the stack is: {0}\n", last);

            Console.WriteLine(" Stack after: ");
            foreach (var elem in myStack)
            {
                Console.WriteLine(elem);
            }
        }
    }
    
}
