var builder = WebApplication.CreateBuilder(args);

//adding swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

//calling swagger
app.UseSwagger();
app.UseSwaggerUI();

app.UseRouting();

app.UseEndpoints(endpoints =>
{
    endpoints.MapPost("ebooks", async (context) => { await context.Response.WriteAsync("creating new ebook"); });
    endpoints.MapGet("ebooks", async (context) => { await context.Response.WriteAsync("Listing all ebooks"); });
});


app.Run();