using Microsoft.EntityFrameworkCore;
using XStuFileBox.EntityFrameworkCore.EntityFrameworkCore;
using XStuFileBox.HttpApi.Extensions;

var builder = WebApplication.CreateBuilder(args);



builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//ÃÌº”DbContext
builder.Services.AddDbContext();

builder.Services.AddUnitOfWork<XStuFileBoxDbContext>();

//  π”√Autofac
builder.UseAutofac();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();
app.MapControllers();
app.Run();
