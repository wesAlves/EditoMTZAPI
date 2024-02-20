var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseRouting(); //Enables Routing for apps

app.UseEndpoints(endpoints =>
{
    endpoints.Map("files/{filename}.{extension}", async context =>
    {
        var fileName = Convert.ToString(context.Request.RouteValues["filename"]);
        var extension = Convert.ToString(context.Request.RouteValues["extension"]);

        await context.Response.WriteAsync($"In files {fileName}.{extension}");
    });

    endpoints.Map("products/details/{id=1}", async context =>
    {
        int id = Convert.ToInt16(context.Request.RouteValues["id"]);

        await context.Response.WriteAsync($"Deatils for {id}");
    });

    endpoints.Map("products/orders/{id:int?}", async context =>
    {
        if (context.Request.RouteValues.ContainsKey("id"))
        {
            var id = Convert.ToInt32(context.Request.RouteValues["id"]);
            await context.Response.WriteAsync($"Order with {id}");
        }
        else
        {
            await context.Response.WriteAsync("Id was not supplied");
        }
    });

    endpoints.Map("sales-reports/{year:int:min(1900)}/{month:alpha}", async context =>
    {
        var year = context.Request.RouteValues["year"];
        var month = context.Request.RouteValues["month"];
        
        await context.Response.WriteAsync($"sales report {year}/{month}");
    });

}); //based on incoming request call approperty end point

app.Run(async context => { await context.Response.WriteAsync("You are at home"); });

app.Run();