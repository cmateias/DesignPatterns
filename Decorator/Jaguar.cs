using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
   public class Jaguar:ICar
    {
        public void ShowBasicDetails()
        {
            Console.WriteLine("Name: " + nameof(Jaguar));
            Console.WriteLine("Model No: XType");
        }

        public double Price()
        {
            return 35000;
        }
    }
}
