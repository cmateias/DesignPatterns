using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class SortedList
    {
        private List<string> _list = new List<string>();
        private ISortStrategy _sortStrategy;

        public void SetSortStrategy(ISortStrategy sortStrategy)
        {
            _sortStrategy = sortStrategy;
        }

        public void Add(string name)
        {
            _list.Add(name);
        }

        public void Sort()
        {
            _sortStrategy.Sort(_list);

            foreach (string name in _list)
            {
                Console.WriteLine(" " + name);
            }

            Console.WriteLine();
        }
    }
}
