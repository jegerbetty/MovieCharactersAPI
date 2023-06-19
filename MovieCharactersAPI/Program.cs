using AutoMapper;
using Microsoft.EntityFrameworkCore;
using MovieCharactersAPI.Data;
using MovieCharactersAPI.Profiles;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//calling the conncetion string:
builder.Services.AddDbContext<MovieCharactersDbContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))); //added after checking stackoverflow, but not sure how to proceed from here

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Automapper (do not have startup.cs - this is what I found was the solution - along with Profile classes
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies()); 
//builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly()); - tried this - didn't work
//builder.Services.AddAutoMapper(typeof(Program)); - tried this alone, as well as with the line below
//builder.Services.AddControllersWithViews();

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
