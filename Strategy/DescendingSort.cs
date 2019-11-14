using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class DescendingSort:ISortStrategy
    {
        public void Sort(List<string> list)
        {
            list.Reverse();
            Console.WriteLine($"{nameof(DescendingSort)} called");
        }
    }
}
