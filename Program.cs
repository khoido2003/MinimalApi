using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using MinimalAPI.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var sqlConBuilder = new SqlConnectionStringBuilder();

// Get this in the appsettings.json file
sqlConBuilder.ConnectionString = builder.Configuration.GetConnectionString
("SQLDbConnection");
sqlConBuilder.UserID = builder.Configuration["UserId"];
sqlConBuilder.Password = builder.Configuration["Password"];


builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(sqlConBuilder.ConnectionString));


var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.Run();





