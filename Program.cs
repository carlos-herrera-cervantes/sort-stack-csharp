using System;
using SortStackConsoleApp.Models;

namespace SortStackConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new MyStack();

            stack.Push(3);
            stack.Push(10);
            stack.Push(1);
            stack.Push(100);
            stack.Sort();

            stack.Print();
        }
    }
}
