using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class CreateObjects
    {
        public static void Run()
        {
            SortedList records = new SortedList();

            records.Add("George");
            records.Add("John");
            records.Add("Allan");
            records.Add("Zoe");
            records.Add("Fred");
            records.Add("Thomas");

            records.SetSortStrategy(new AscendingSort());
            records.Sort();

            records.SetSortStrategy(new DescendingSort());
            records.Sort();

            records.SetSortStrategy(new FakeSort());
            records.Sort();

            Console.ReadKey();
        }
    }
}
