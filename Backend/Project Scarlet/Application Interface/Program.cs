using Domain.Clients;
using Interfaces.Squarespace.Clients;
using RestSharp;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IRestClient, RestClient>();
builder.Services.AddScoped<ISquarespaceClient, SquarespaceClient>();

#if DEBUG
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: "local",
        policy =>
        {
            policy.AllowAnyOrigin();
        });
});
#endif

var app = builder.Build();

#if DEBUG
app.UseCors("local");
#endif

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
