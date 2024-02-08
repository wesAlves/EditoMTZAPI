var builder = WebApplication.CreateBuilder(args);

// Add services to the container
builder.Services.AddControllers();

//adding swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

//calling swagger
app.UseSwagger();
app.UseSwaggerUI();

app.UseHsts();
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();