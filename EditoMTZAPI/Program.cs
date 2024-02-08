var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();


app.UseRouting();

app.UseEndpoints(endpoints =>
{
    endpoints.MapPost("ebooks", async (context) => { await context.Response.WriteAsync("creating new ebook"); });
    endpoints.MapGet("ebooks", async (context) => { await context.Response.WriteAsync("Listing all ebooks"); });
});



app.Run();