namespace WebApplication1;

public static class Configuration
{
    public static void RegisterEndpointsForAnimals(this IEndpointRouteBuilder app )
    {
        app.MapGet("/api/v1/animals", (IAnimalService service) =>
        {
            
            return TypedResults.Ok(service.GetAnimals());
        });
        app.MapPost("/api/v1/animals/{id:int}", (IAnimalService service) => { return TypedResults.Ok(service.GetAnimalById(1)); });
    }
}