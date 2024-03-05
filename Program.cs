using ZooManagment.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<Zoo>();

builder.Services.AddControllers();  // so our program kmows about controllers

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapControllers();
app.Run();
// how to use database context in our Program.cs - builder.Services.AddDbContext<Zoo>();
