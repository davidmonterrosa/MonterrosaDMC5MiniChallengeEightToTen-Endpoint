using MonterrosaDMC5MiniChallengeEightToTen_Endpoint.Controllers;
using MonterrosaDMC5MiniChallengeEightToTen_Endpoint.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<GuessItServices>();
builder.Services.AddScoped<Magic8BallServices>();
builder.Services.AddScoped<RestaurantPickerServices>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
