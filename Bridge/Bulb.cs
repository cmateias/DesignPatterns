using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    public class Bulb:IElectronicDevice
    {
        public void Start()
        {
            Console.WriteLine("Warm up the bulb");
            Console.WriteLine("Glow the bulb");
        }

        public void Stop()
        {
            Console.WriteLine("Switch of the bulb");
        }
    }
}
