using Hongyu.framework.Middlewares;
using Hongyu.framework.Repository.Interfaces;
using Hongyu.framework.Repository;
using Hongyu.framework.Common.InitCore;
using Hongyu.framework.Application;
using Hongyu.framework.Application.Interfaces;
using Microsoft.EntityFrameworkCore;
using Hongyu.framework.Repository.UnitOfWork;
using Autofac.Extensions.DependencyInjection;
using Autofac;
using System.Reflection;
using Hongyu.framework.Common.IDependencies;
using System.Text.RegularExpressions;
using Hongyu.framework.Models.Entitys;
using Microsoft.AspNetCore.Components.CompilerServices;
using System.Runtime.CompilerServices;
using log4net;
using Hongyu.framework.Repositories;
using Autofac.Core;

var builder = WebApplication.CreateBuilder(args);
//builder.Services.AddTransient<ILogHelper, LogHelper>();
// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Host
    .UseServiceProviderFactory(new AutofacServiceProviderFactory())
    .ConfigureContainer<ContainerBuilder>(builder =>
    {
        builder.RegisterModule(new AutofacModuleRegister());
        builder.RegisterGeneric(typeof(BaseRepository<>))
       .As(typeof(IRepository<>))
       .InstancePerLifetimeScope();
    });
builder.Services.AddTransient(typeof(IRepository<>), typeof(BaseRepository<>));
//builder.Services.AddIocRegister();

var app = builder.Build();
app.UseRequRespLogMiddle();
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
