namespace WebApplication1;

public class Animal
{
    public Animal(int id, string kategoria, double masa, string imie, string kolorSierci)
    {
        Id = id;
        Kategoria = kategoria;
        Masa = masa;
        Imie = imie;
        KolorSierci = kolorSierci;
    }

    public int Id { get; set; }
    public string Kategoria { get; set; }
    public double Masa { get; set; }
    public string Imie { get; set; }
    public string KolorSierci { get; set; }
    
}