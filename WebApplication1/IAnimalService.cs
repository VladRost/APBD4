namespace WebApplication1;

public interface IAnimalService
{
    IEnumerable<Animal> GetAnimals();
    Animal GetAnimalById(int id);
    Animal AddAnimal(Animal animal);
    void UpdateAnimal(Animal animal);
    void DeleteAnimal(int id);
}