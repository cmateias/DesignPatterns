using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy
{
    public class SharedFolder:ISharedFolder
    {
        public void PerformRWOperations()
        {
            Console.WriteLine("Performing Read Write operation on the Shared Folder");
        }
    }
}
