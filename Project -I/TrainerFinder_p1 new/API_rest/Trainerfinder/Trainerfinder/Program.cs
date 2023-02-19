global using Serilog;
using Trainerfinder.Entities;
using BuisnessLogic;
using Models;
using Microsoft.EntityFrameworkCore;
using FluentAPI;

var builder = WebApplication.CreateBuilder(args);
Log.Logger = new LoggerConfiguration()
        .WriteTo.File(@"./Logs/logFile.txt")
             .CreateLogger();

Log.Logger.Information("----Program starts----");

// Add services to the container.
builder.Services.AddControllers();
            builder.Services.AddMemoryCache();
            builder.Services.AddControllers().AddXmlSerializerFormatters();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
Log.Logger.Information("Program.cs--line->22");
var config = builder.Configuration.GetConnectionString("connectionstring");
            builder.Services.AddDbContext<AssociatesDbContext>(options => options.UseSqlServer(config));

            builder.Services.AddScoped<IRepo<Trainerfinder.Entities.User>, FluentAPI.SqlRepo>();
            builder.Services.AddScoped<ILogic, Logic>();

            builder.Services.AddScoped<IEducationRepo<Trainerfinder.Entities.Education>, FluentAPI.EducationSqlRepo>();
            builder.Services.AddScoped<IEducationLogic, EducationLogic>();

            builder.Services.AddScoped<IExperienceRepo<Trainerfinder.Entities.Experience>, FluentAPI.ExperienceSqlRepo>();
            builder.Services.AddScoped<IExperienceLogic, ExperienceLogic>();

            builder.Services.AddScoped<ISkillRepo<Trainerfinder.Entities.Skill>, FluentAPI.SkillSqlRepo>();
            builder.Services.AddScoped<ISkillLogic, SkillLogic>();
            builder.Services.AddScoped<Validation>();

Log.Logger.Information("Program.cs--line->39");

var app = builder.Build();
Log.Logger.Information("Program.cs--line->42");
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();
Log.Logger.Information("Program.cs--line->55");
app.Run();

