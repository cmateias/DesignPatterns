namespace Abstract
{
    public class SeaAnimalFactory:AnimalFactory
    {
        public override IAnimal GetAnimal(string animalType)
        {
            switch (animalType)
            {
                case "Shark":
                    return new Shark();
                case "Octopus":
                    return new Octopus();
                default:
                    return null;
            }
        }
    }
}