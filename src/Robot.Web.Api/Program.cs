using Robot.Service;
using Robot.Storage;
using Robot.Storage.PostgreSQL;
using Robot.Web.Api;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//DI
builder.Services.AddTransient<IRobotService, RobotService>();
builder.Services.AddTransient<ICleanService, CleanService>();
builder.Services.AddOptions<PostgreSQLOptions>()
    .Configure<IConfiguration>(
        (options, configuration) =>
            configuration.GetSection("PostgreSQLOptions").Bind(options));
builder.Services.AddTransient<IDataStorageService, PostgreSQLStorageService>();
//IConfiguration

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapControllers();

app.Run();
