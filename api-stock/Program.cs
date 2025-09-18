var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDependencyInjection();

var app = builder.Build();

app.UseHttpsRedirection();

app.Run();
