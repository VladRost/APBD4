namespace WebApplication1;

public interface IAnimalService
{
    IEnumerable<Animal> GetAnimals();
    Animal GetAnimalById(int id);
    Animal AddAnimal(Animal animal);
    Animal UpdateAnimal(int id,Animal updateAnimal);
    Animal DeleteAnimal(int id);
}