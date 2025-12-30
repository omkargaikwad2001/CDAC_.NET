using CompanyMgmt.Repositories;
using Microsoft.EntityFrameworkCore;
using P7_RESTUsingRepositoryPattern.Models;
using P7_RESTUsingRepositoryPattern.Repositories;
using System.Text.Json.Serialization;

namespace P7_RESTUsingRepositoryPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // -------------------- SERVICES --------------------

            builder.Services.AddControllers()
                .AddJsonOptions(options =>
                {
                    options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
                });

            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            // MySQL DbContext
            builder.Services.AddDbContext<CompanydbContext>(options =>
            {
                options.UseMySql(
                    builder.Configuration.GetConnectionString("MySqlCon"),
                    ServerVersion.AutoDetect(builder.Configuration.GetConnectionString("MySqlCon"))
                );
            });

            // Repository DI
            builder.Services.AddScoped<IRepository<Department>, DepartmentRepository>();
            builder.Services.AddScoped<IRepository<Employee>, EmployeeRepository>();

            // -------------------- CORS --------------------
            builder.Services.AddCors(options =>
            {
                options.AddPolicy("AllowReact",
                    policy =>
                    {
                        policy
                            .WithOrigins("http://localhost:5173")
                            .AllowAnyHeader()
                            .AllowAnyMethod();
                    });
            });

            var app = builder.Build();

            // -------------------- MIDDLEWARE --------------------

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseCors("AllowReact");   // ✅ CORS MUST be here

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}
