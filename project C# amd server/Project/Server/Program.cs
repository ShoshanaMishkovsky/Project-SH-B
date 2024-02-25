//using Bl;
//using Bl.BlApi;
//using Bl.Blservices;
//using Dal;
//using Dal.DalApi;
//using Dal.Models;
//using Dal.Services;
//using DataAccess;
//using Microsoft.EntityFrameworkCore;

//var builder = WebApplication.CreateBuilder(args);

//// Add services to the container.

//builder.Services.AddControllers();

////builder.Services.AddSingleton<DalManager>();
//builder.Services.AddSingleton<BlManager>();
//// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
//builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();

////builder.Services.AddScoped<Dal.DalApi.IDietitianService, Dal.Services.DietitianService>();
////builder.Services.AddScoped<IBlDietitianService, BlDietitianService>();
//DBActions db = new DBActions(builder.Configuration);
//string connStr = db.GetConnectionString("ClinicContext");
//builder.Services.AddDbContext<NutritionContext>(opt => opt.UseSqlServer(connStr));
//var app = builder.Build();

//// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
//    app.UseSwagger();
//    app.UseSwaggerUI();
//}

//app.UseHttpsRedirection();

//app.UseAuthorization();

//app.MapControllers();

//app.Run();
using Bl;
using Bl.BlApi;
using Bl.Blservices;
using Bl.BlModels;
using Dal;
using Dal.Models;
using Microsoft.EntityFrameworkCore;

using Bl;
using DataAccess;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

// builder.Services.AddScoped<IDoctor, DoctorRepo>();
builder.Services.AddSingleton<BlManager>();


DBActions db = new DBActions(builder.Configuration);
string connStr = db.GetConnectionString("NutritionContext");
builder.Services.AddDbContext<NutritionContext>(opt => opt.UseSqlServer(connStr));
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseHttpsRedirection();

app.UseAuthorization();


app.MapControllers();
app.Run();