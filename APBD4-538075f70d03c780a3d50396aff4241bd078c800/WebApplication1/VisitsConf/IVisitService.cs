namespace WebApplication1;

public interface IVisitService
{
    List<Visit> GetAnimalVisits(int id);
    Visit CreateVisit(Visit visit);
}