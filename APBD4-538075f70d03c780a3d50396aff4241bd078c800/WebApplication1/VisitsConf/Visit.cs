
public class Visit
{
    public int Id { get; set; }
    public string VisitDate { get; set; }
    public int AnimalId { get; set; }
    public string Description { get; set; }
    public double Price { get; set; }
    public Visit(int id, string VisitDate, int AnimalId, string Description, double Price)
    {
        Id = id;
        this.VisitDate = VisitDate;
        this.AnimalId = AnimalId;
        this.Description  = Description ;
        this.Price = Price;
    }
}