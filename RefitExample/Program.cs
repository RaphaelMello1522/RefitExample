using Refit;
using RefitExample.Repositories.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

//Refit Client Base URL Address//
builder.Services.AddRefitClient<INewsPapperRepository>().ConfigureHttpClient(c =>
{
    c.BaseAddress = new Uri("https://chroniclingamerica.loc.gov/newspapers.json");
});

builder.Services.AddRefitClient<IDigitalOceanRepository>().ConfigureHttpClient(c =>
{
    c.BaseAddress = new Uri("https://status.digitalocean.com/api");
});

builder.Services.AddRefitClient<IUsersClient>().ConfigureHttpClient(c =>
{
    c.BaseAddress = new Uri("https://jsonplaceholder.typicode.com");
});

builder.Services.AddRefitClient<IRickAndMortyRepository>().ConfigureHttpClient(c =>
{
    c.BaseAddress = new Uri("https://rickandmortyapi.com/api");
});

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
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
