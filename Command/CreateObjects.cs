using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    public static class CreateObjects
    {
        public static void Run()
        {
            var modifyPrice = new ModifyPrice();
            var product = new Product("Phone", 500);

            Execute(product, modifyPrice, new ProductCommand(product, PriceAction.Decrease, 100));
            Execute(product, modifyPrice, new ProductCommand(product, PriceAction.Decrease, 50));
            Execute(product, modifyPrice, new ProductCommand(product, PriceAction.Increase, 25));

            Console.WriteLine(product);

            modifyPrice.UndoActions();
            Console.WriteLine(product);
        }

        private static void Execute(Product product, ModifyPrice modifyPrice, ProductCommand productCommand)
        {
            modifyPrice.SetCommand(productCommand);
            modifyPrice.Invoke();
        }
    }
}
