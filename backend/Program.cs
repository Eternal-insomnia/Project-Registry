using Backend.Repository;
using Backend.Repository.Implementations;
using Backend.Repository.Interfaces;
using Backend.Services.Implementations;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Logging.ClearProviders();
builder.Logging.AddSimpleConsole();

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddCors(options =>
{
    options.AddPolicy("CorsFrontendPolicy",
        builder =>
        {
            builder.WithOrigins("http://localhost:5173")
                   .AllowAnyHeader()
                   .AllowAnyMethod();
        });
});

builder.Services.AddDbContext<RepositoryContext>(options =>
    options.UseNpgsql(connectionString));

// Add services to the container.
builder.Services.AddScoped(typeof(IProjectGeneralInfoRepository), typeof(ProjectGeneralInfoRepository));
builder.Services.AddScoped(typeof(IProjectConditionViewRepository), typeof(ProjectConditionViewRepository));

builder.Services.AddControllers();
builder.Services.AddScoped<ProjectGeneralInfoService>();
builder.Services.AddScoped<ProjectConditionViewService>();

builder.Services.AddAutoMapper(typeof(MappingProfile));

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseCors("CorsFrontendPolicy");

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
