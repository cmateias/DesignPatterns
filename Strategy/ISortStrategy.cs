using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public interface ISortStrategy
    {
        void Sort(List<string> list);
    }
}
