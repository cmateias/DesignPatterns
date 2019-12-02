using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator
{
    public interface IIterator
    {
        Employee First();
        Employee Next();
        bool IsCompleted { get; }
    }
}
