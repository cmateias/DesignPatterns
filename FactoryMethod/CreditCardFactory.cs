using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public abstract class CreditCardFactory
    {
        protected abstract ICreditCard MakeProduct();
        public ICreditCard CreateProduct()
        {
            return this.MakeProduct();
        }
    }
}
