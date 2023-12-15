using API.Extensions;
using Application;
using Domain;
using FluentValidation;
using Microsoft.AspNetCore.Identity;
using Persistence;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
        

builder.Services.AddDatabaseServices(builder.Configuration);

builder.Services.AddControllers();
builder.Services.AddIdentityCore<AppUser>().AddRoles<IdentityRole>().AddEntityFrameworkStores<DataContext>();
builder.Services.AddIdentityServices(builder.Configuration);
builder.Services.AddApplication();
builder.Services.AddApplicationService();
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen();

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
