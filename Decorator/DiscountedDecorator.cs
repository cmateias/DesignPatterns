using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class DiscountedDecorator:CarDecorator
    {
        public DiscountedDecorator(ICar car) : base(car) { }

        public void DiscountedPrice()
        {
            Console.WriteLine("Discounted Price: " + .10 * base.Price());
        }
    }
}
