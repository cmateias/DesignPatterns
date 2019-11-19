using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    public class Refrigerator:IElectronicDevice
    {
        public void Start()
        {
            Console.WriteLine("Compressor Start");
            Console.WriteLine("Ice Cooling Start");
        }

        public void Stop()
        {
            Console.WriteLine("Ice Cooling Stop");
            Console.WriteLine("Compressor Stop");
        }
    }
}
