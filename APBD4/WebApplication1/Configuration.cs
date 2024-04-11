namespace WebApplication1;

public static class Configuration
{
    public static void RegisterEndpointsForAnimals(this IEndpointRouteBuilder app)
    {
        app.MapGet("/api/v1/animals", (IAnimalService service) =>
        {
            
            return TypedResults.Ok(service.GetAnimals());
        });
        app.MapGet("/api/v1/animals/{id}", (IAnimalService service) => { 
            return TypedResults.Ok(service.GetAnimalById(1)); 
        });
        app.MapPost("/api/v1/animals",(IAnimalService service) =>
        {
            
            return TypedResults.Ok(service.AddAnimal(new Animal(3,"ptak",3,"temp","niebeski")));
        });
        app.MapPut("/api/v1/animals/{id}",(IAnimalService service) =>
        {
            
            return TypedResults.Ok(service.UpdateAnimal(1,new Animal(1,"KON",342.23,"animal","czarny")));

        });
        app.MapDelete("/api/v1/animals/{id}",(IAnimalService service) =>
        {
            
            return TypedResults.Ok(service.DeleteAnimal(1));

        });
        app.MapGet("/api/v1/visits/{animalId}",(IVisitService service) =>
        {
            
            return TypedResults.Ok(service.GetAnimalVisits(2));

        });
        app.MapPut("/api/v1/visits",(IVisitService service) =>
        {
            
            return TypedResults.Ok(service.CreateVisit(new Visit(3,"1092",2,"test visit 221",453.25)));

        });



    }
}