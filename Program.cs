using MiniChallengeEightToTen.Service;
using MiniChallengeEightToTen.Service.GuessIt;
using MiniChallengeEightToTen.Service.Magic8;
using MiniChallengeEightToTen.Service.RestaurantPicker;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IGuessItService, GuessItService>();
builder.Services.AddScoped<IRestaurantPickerService, RestaurantPickerService>();
builder.Services.AddScoped<IMagic8Service, Magic8Service>();

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
