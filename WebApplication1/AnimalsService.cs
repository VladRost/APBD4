namespace WebApplication1;

public class AnimalsService:IAnimalService
{
    private static List<Animal> _animals = new List<Animal>() { new Animal(1,"adf",2.1,"test","czerwony"),new Animal(2,"adasdff",2.6,"test2","zolty")};
    public IEnumerable<Animal> GetAnimals()
    {
        return _animals;
    }

    public Animal GetAnimalById(int i)
    {
        return _animals[i];
    }
}