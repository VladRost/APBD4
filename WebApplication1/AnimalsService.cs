namespace WebApplication1;

public class AnimalsService:IAnimalService
{
    private static List<Animal> _animals = {new Animal(),new Animal(),new Animal(),new Animal()};
    public IEnumerable<Animal> GetAnimals()
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Animal> GetAnimalById()
    {
        throw new NotImplementedException();
    }
}