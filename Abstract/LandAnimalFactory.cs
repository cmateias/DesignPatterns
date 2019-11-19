namespace Abstract
{
    public class LandAnimalFactory:AnimalFactory
    {
        public override IAnimal GetAnimal(string animalType)
        {
            switch (animalType)
            {
                case "Dog": 
                    return new Dog();
                case "Cat":
                    return new Cat();
                case "Lion":
                    return new Lion();
                default:
                    return null;
            }
        }
    }
}