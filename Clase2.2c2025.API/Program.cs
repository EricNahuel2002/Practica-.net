using Clase2._2c2025.Logica;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<IReseñaServicio, ReseñaServicio>(); //SE AGREGA EL SERVICIO AL PROGRAM DE LA API, POR CADA SERVICIO NUEVO QUE SE CREE Y SE LO QUIERA USAR
                                                                   //SE LO AGREGA ACA
builder.Services.AddSingleton<ITipoLocalServicio, TipoLocalServicio>();

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
