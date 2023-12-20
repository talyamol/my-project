using EventHalls.Entities;
using Solid.Core.Repositories;
using Solid.Core.Services;
using Solid.Data.Repositories;
using Solid.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IEventRepository, EventsRepository>();
builder.Services.AddScoped<IHallsRepository, HallsRepository>();
builder.Services.AddScoped<IInvitedRepository, InvitedRepository>();
builder.Services.AddScoped<IEventsService, EventsService>();
builder.Services.AddScoped<IHallsService, HallsService>();
builder.Services.AddScoped<IInvitedService, InvitedService>();

builder.Services.AddSingleton<DataContext>();

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
