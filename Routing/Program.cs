var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseRouting(); //Enables Routing for apps

app.Use(async (context, next) =>
{
    context.GetEndpoint();
    await next(context);
});

app.UseEndpoints(endpoints =>
{
    //add endpoints here
    endpoints.MapGet("map1", async (context) => { await context.Response.WriteAsync("In Map 1"); });

    endpoints.MapPost("map2", async (context) => { await context.Response.WriteAsync("In Map 2"); });
    
}); //based on incoming request call approperty end point

app.Run(async context => { await context.Response.WriteAsync("You are at home"); });

app.Run();