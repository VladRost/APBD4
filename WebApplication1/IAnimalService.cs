namespace WebApplication1;

public interface IAnimalService
{
    IEnumerable<Animal> GetAnimals();
    Animal GetAnimalById(int i);
}