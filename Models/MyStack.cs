using System;
using System.Collections.Generic;

namespace SortStackConsoleApp.Models
{
    public class MyStack : Stack<int>
    {
        #region snippet_Sort

        /// <summary>Sorts the elements on the stack</summary>
        public void Sort()
        {
            var tempStack = new Stack<int>();

            while (base.Count != 0)
            {
                var temp = base.Pop();

                while (tempStack.Count != 0 && tempStack.Peek() > temp)
                {
                    base.Push(tempStack.Pop());
                }

                tempStack.Push(temp);
            }

            while (tempStack.Count != 0)
            {
                base.Push(tempStack.Pop());
            }
        }

        #endregion

        #region snippet_Print

        /// <summary>Prints the elements by extracting them</summary>
        public void Print()
        {
            while (base.Count != 0)
            {
                Console.WriteLine(base.Pop());
            }
        }

        #endregion
    }
}