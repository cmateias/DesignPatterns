using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strategy
{
    public class FakeSort : ISortStrategy
    {
        public void Sort(List<string> list)
        {
            Console.WriteLine($"{nameof(FakeSort)} called");
        }
    }
}
