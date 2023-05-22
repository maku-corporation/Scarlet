using Azure.Identity;
using Database;
using Database.Context;
using Database.Repositories;
using Domain.Clients;
using Domain.Core.Coupons;
using Domain.Filtering;
using Interfaces.Core;
using Interfaces.Persistence;
using Interfaces.Squarespace.Clients;
using Microsoft.EntityFrameworkCore;
using RestSharp;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

// https://stackoverflow.com/questions/61881770/invalidoperationexception-cant-use-schemaid-the-same-schemaid-is-already-us
builder.Services.AddSwaggerGen(options =>
{
    options.CustomSchemaIds(type => type.Name);
});

// Data layer
builder.Services.AddDbContext<ScarletContext>(options =>
    options.UseSqlServer("server=.\\SQLEXPRESS;database=MKLeje12DB;Trusted_Connection=true;TrustServerCertificate=true"));
builder.Services.AddScoped<IScarletContext, ScarletContext>();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

// Services
builder.Services.AddScoped<IRestClient, RestClient>();
builder.Services.AddScoped<ISquarespaceClient, SquarespaceClient>();

// Core
builder.Services.AddScoped<IRandomGenerator, RandomGenerator>();
builder.Services.AddScoped<IPrefix, Prefix>();
builder.Services.AddScoped<IGenerator, Generator>();

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

{
    using (var scope = app.Services.CreateScope())
    {
        var services = scope.ServiceProvider;

        try
        {
            using (var context = services.GetRequiredService<IScarletContext>()) 
            {
                DbInitializer.Initialize(context as ScarletContext);
                //await context.Database.MigrateAsync();
            }
        }
        catch (Exception exception)
        {
            var logger = services.GetRequiredService<ILogger<Program>>();
            logger.LogError(exception, "An error occurred while seeding the database.");
        }

    }

}

if (!app.Environment.IsDevelopment())
{
    app.UseCors("local");
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

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
