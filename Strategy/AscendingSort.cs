using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace Strategy
{
    public class AscendingSort:ISortStrategy
    {
        public void Sort(List<string> list)
        {
            list.Sort();
            Console.WriteLine($"{nameof(AscendingSort)} called");
        }
    }
}
