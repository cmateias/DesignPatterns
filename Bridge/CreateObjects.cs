using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    public class CreateObjects
    {
        public static void Run()
        {
            Switch s = new Switch();
            s.SetDevice(new Bulb());
            s.On();
            s.Off();

            s.SetDevice(new Refrigerator());
            s.On();
            s.Off();

            Console.Read();
        }
    }
}
