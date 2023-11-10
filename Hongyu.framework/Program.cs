using Hongyu.framework.Common.Log;
using Hongyu.framework.Middlewares;
using Hongyu.framework.Common.InitCore;
using log4net.Appender;
using Hongyu.framework.Common.AppSetting;
using System.Configuration;

var builder = WebApplication.CreateBuilder(args);
//builder.Services.AddTransient<ILogHelper, LogHelper>();
// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
///¶¯Ì¬ÒÀÀµ×¢Èë
builder.Services.AddIocRegister();
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
