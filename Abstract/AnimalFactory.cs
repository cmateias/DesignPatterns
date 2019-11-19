using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract
{
    public abstract class AnimalFactory
    {
        public abstract IAnimal GetAnimal(string animalType);

        public static AnimalFactory CreateAnimalFactory(string factoryType)
        {
            if (factoryType.Equals("Sea"))
            {
                return new SeaAnimalFactory();
            }
            else
            {
                return new LandAnimalFactory();
            }
        }
    }
}
