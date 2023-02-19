using MediatR;
using MovieManagement.Library.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IDataRepository, DataRepository>();
builder.Services.AddMediatR(typeof(DataRepository).Assembly);

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



//So this project has to deal with CQRS - Command Query Responsibility Segregation
//CQRS can be splitted into two the Read side and the add side 
//the Read side mainly performs things like queries, complex data mapping e.t.c
//The Write side has complicated business logic and multiple validation points
//THEREFORE             Reads = Commands(saves)
//                        Write = Querie(Reads)



//ASP.Net Core API using MediatR and CQRS


