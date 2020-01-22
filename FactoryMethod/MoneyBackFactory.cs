using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public class MoneyBackFactory : CreditCardFactory
    {
        protected override ICreditCard MakeProduct()
        {
            ICreditCard product = new MoneyBack();
            return product;
        }
    }
}
