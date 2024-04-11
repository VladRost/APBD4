using System.Diagnostics.Tracing;

namespace WebApplication1;

public class AnimalsService:IAnimalService
{
    private static List<Animal> _animals = new List<Animal>() { new Animal(1,"adf",2.1,"test","czerwony"),new Animal(2,"adasdff",2.6,"test2","zolty")};
    public IEnumerable<Animal> GetAnimals()
    {
        return _animals;
    }

    public Animal GetAnimalById(int id)
    {
        return _animals.FirstOrDefault(a => a.Id == id);
    }
    public Animal AddAnimal(Animal animal){
        _animals.Add(animal);
        return animal;
    }
    public Animal UpdateAnimal(int id,Animal updateAnimal){
         var index = _animals.FindIndex(a => a.Id == id);
        if (index != -1)
        {
            updateAnimal.Id = id;
            _animals[index] = updateAnimal;
            return updateAnimal;
        }
        else
        {
            return null;
        }
    }
    public Animal DeleteAnimal(int id){
        var animal = _animals.FirstOrDefault(a => a.Id == id);
        _animals.Remove(animal);
        return animal;
    }
}