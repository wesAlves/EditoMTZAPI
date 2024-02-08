using EditoMTZAPI.DatabaseContext;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container
builder.Services.AddControllers();

//adding swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Context for db
builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseNpgsql(builder.Configuration.GetConnectionString("Default"));
});

var app = builder.Build();

//calling swagger
app.UseSwagger();
app.UseSwaggerUI();

app.UseHsts();
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();