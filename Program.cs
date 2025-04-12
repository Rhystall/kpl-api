var builder = WebApplication.CreateBuilder(args);

// Tambahin controller support
builder.Services.AddControllers();

// Swagger (OpenAPI) support
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Swagger saat development
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

// Penting: mapping controller
app.MapControllers();

app.Run();
