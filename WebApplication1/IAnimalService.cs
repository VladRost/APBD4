namespace WebApplication1;

public interface IAnimalService
{
    IEnumerable<Animal> GetAnimals();
    IEnumerable<Animal> GetAnimalById();
}