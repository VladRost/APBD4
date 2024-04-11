namespace WebApplication1;

public class VisitService:IVisitService
{
    private static List<Visit> _visits = new List<Visit>(){new Visit(1,"2019",1,"test visit",4.25),new Visit(2,"2029",2,"test visit 2",123.25)};
    public List<Visit> GetAnimalVisits(int animalId){
        IEnumerable<Visit> query = _visits.Where(v => v.AnimalId == animalId);
        return query.ToList();
    }
    public Visit CreateVisit(Visit visit){
        _visits.Add(visit);
        return visit;
    }
}