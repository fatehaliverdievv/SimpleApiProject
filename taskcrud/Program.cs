using Microsoft.EntityFrameworkCore;
using taskcrud.DAL;
using FluentValidation;
using FluentValidation.AspNetCore;
using AutoMapper;
using taskcrud.Services.Abstracts;
using taskcrud.Services.Implements;
using taskcrud;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddFluentValidationAutoValidation();
builder.Services.AddValidatorsFromAssemblyContaining<Program>();
builder.Services.AddAutoMapper(typeof(Program));
builder.Services.AddServices();
builder.Services.AddDbContext<TaskDbContext>(opt => opt.UseSqlServer(builder.Configuration.GetConnectionString("MSSql")));
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
