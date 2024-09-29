using ConsentCode.Repository;
using ConsentCode.Repository.Implementations;
using ConsentCode.Repository.Interfaces;
using ConsentCode.Services.Implementations;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Logging.ClearProviders();
builder.Logging.AddSimpleConsole();

var connectionString = builder.Configuration.GetConnectionString("dbConnection");

builder.Services.AddDbContext<RepositoryContext>(options =>
    options.UseNpgsql(connectionString));

// Add services to the container.
builder.Services.AddScoped(typeof(IProjectGeneralInfoRepository), typeof(ProjectGeneralInfoRepository));

builder.Services.AddControllers();
builder.Services.AddScoped<ProjectGeneralInfoService>();

builder.Services.AddAutoMapper(typeof(MappingProfile));

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
