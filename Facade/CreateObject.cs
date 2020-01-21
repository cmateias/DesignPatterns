using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    public class CreateObject
    {
        public static void Run()
        {
            Order order = new Order();
            order.PlaceOrder();
            Console.Read();
        }
    }
}
