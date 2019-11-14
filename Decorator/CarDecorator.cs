using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public abstract class CarDecorator:ICar
    {
        private ICar car;

        public CarDecorator(ICar _car)
        {
            car = _car;
        }

        public void ShowBasicDetails()
        {
            car.ShowBasicDetails();
        }

        public double Price()
        {
            return car.Price();
        }
    }
}
