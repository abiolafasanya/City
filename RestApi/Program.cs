using Microsoft.EntityFrameworkCore;
using RestApi.Data;
using RestApi.DbContexts;
using RestApi.Services.Mail;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
Log.Logger = new LoggerConfiguration()
    .MinimumLevel.Debug()
    .WriteTo.Console()
    .WriteTo.File("logs/cityinfo.txt", rollingInterval: RollingInterval.Day)
    .CreateLogger();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Host.UseSerilog();

builder.Services.AddControllers(options =>
{
    options.ReturnHttpNotAcceptable = true;
})  .AddNewtonsoftJson()
    .AddXmlDataContractSerializerFormatters();

#if DEBUG
    builder.Services.AddTransient<IMailService, LocalMailService>();
#else 
    builder.Services.AddTransient<IMailService, CloudMailService>();
#endif

builder.Services.AddSingleton<CityDataStore>();

// Inject Db Context
builder.Services.AddDbContext<CityDbContext>(options =>
options.UseSqlite(builder.Configuration.GetConnectionString("CityDbConnectionString"))
//options.UseSqlServer(builder.Configuration.GetConnectionString("CityDbConnectionString"))
);

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
