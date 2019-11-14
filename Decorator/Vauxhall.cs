using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class Vauxhall:ICar
    {
        public void ShowBasicDetails()
        {
            Console.WriteLine("Name: " + nameof(Vauxhall));
            Console.WriteLine("Model No: Astra");
        }

        public double Price()
        {
            return 15000;
        }
    }
}
