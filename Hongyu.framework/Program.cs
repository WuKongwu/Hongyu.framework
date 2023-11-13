using Hongyu.framework.Middlewares;
using Hongyu.framework.Repository.Interfaces;
using Hongyu.framework.Repository;
using Hongyu.framework.Common.InitCore;
var builder = WebApplication.CreateBuilder(args);
//builder.Services.AddTransient<ILogHelper, LogHelper>();
// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
///¶¯Ì¬ÒÀÀµ×¢Èë
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
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
