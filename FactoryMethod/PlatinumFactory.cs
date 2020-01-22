using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public class PlatinumFactory : CreditCardFactory
    {
        protected override ICreditCard MakeProduct()
        {
            ICreditCard product = new Platinum();
            return product;
        }
    }
}
