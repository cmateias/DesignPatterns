using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator
{
    public interface ICollection
    {
        Iterator CreateIterator();
    }
}
