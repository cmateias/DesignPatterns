using System;

namespace Bridge
{
    public static class CreateObjects
    {
        public static void Run()
        {
            var s = new Switch();
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
