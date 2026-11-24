using DSW_3P_EJ01.Repositories;
using DSW_3P_EJ01.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi();

builder.Services.AddControllers();

builder.Services.AddScoped<IPersonajeRepository, PersonajeJsonRepository>();
builder.Services.AddScoped<IPersonajeService, PersonajeService>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    //Mapear el swagger
    app.UseSwaggerUI(options =>{
    options.SwaggerEndpoint("/openapi/v1.json", "API de Personajes V1");
    });
}

app.UseHttpsRedirection();

app.MapControllers();

app.Run();
