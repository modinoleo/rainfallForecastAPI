using RainfallForecastAPI.Core.APIClients.Contracts;
using RainfallForecastAPI.Core.Configurations;
using RainfallForecastAPI.Core.Services.Contracts;
using RainfallForecastAPI.Core.Services.Implementations;
using RainfallForecastAPI.Infrastructure.APIClient.Implementations;

var builder = WebApplication.CreateBuilder(args);
IConfiguration config = new ConfigurationBuilder().AddJsonFile("appsettings.json",true,true).Build();
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

builder.Services.AddTransient<IRainfallForecastService, RainfallForecastService>();
builder.Services.AddTransient<IRainfallForecastApiClient, RainfallForecastApiClient>();
builder.Services.Configure<RainfallApiOptions>(config.GetSection("RainfallApi"));
builder.Services.AddHttpClient<RainfallForecastApiClient>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
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
