using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class CreateObjects
    {
        public static void Run()
        {
            ICar vauxhallCar = new Vauxhall();
            vauxhallCar.ShowBasicDetails();

            DiscountedDecorator decoratorVauxhall = new DiscountedDecorator(vauxhallCar);
            decoratorVauxhall.DiscountedPrice();

            ICar jaguarCar = new Jaguar();
            jaguarCar.ShowBasicDetails();

            DiscountedDecorator decoratorJaguar = new DiscountedDecorator(jaguarCar);
            decoratorJaguar.DiscountedPrice();

            Console.Read();
        }
    }
}
