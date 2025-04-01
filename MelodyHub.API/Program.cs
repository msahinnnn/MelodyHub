using MelodyHub.Persistence;
using MelodyHub.Infrastructure;
using Amazon.S3;
using Microsoft.OpenApi.Models;
using Microsoft.AspNetCore.Diagnostics;


var builder = WebApplication.CreateBuilder(args);


builder.Services.AddPersistenceServices(builder.Configuration);
builder.Services.AddInfrastructureServices();


builder.Services.AddControllers();
builder.Services.AddLogging(logging => logging.AddConsole());
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();

builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "My API", Version = "v1" });
});

var app = builder.Build();

app.UseExceptionHandler(errorApp =>
{
    errorApp.Run(async context =>
    {
        var error = context.Features.Get<IExceptionHandlerFeature>();
        if (error != null)
        {
            Console.WriteLine($"Global error: {error.Error.Message}");
            await context.Response.WriteAsync($"Error: {error.Error.Message}");
        }
    });
});

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    //app.UseSwaggerUI();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "MelodyHub API v1"));

}



app.UseHttpsRedirection();

//app.UseAuthorization();

app.MapControllers();

app.Run();
