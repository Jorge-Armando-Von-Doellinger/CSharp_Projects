
using HMS.Application.Applications;
using HMS.Application.Interfaces;
using HMS.Domain.Interfaces.Repositories;
using HMS.Domain.Interfaces.Repositories.Base;
using HMS.Domain.Interfaces.Services;
using HMS.Domain.Services;
using HMS.Infrastructure.BaseRepository;
using HMS.Infrastructure.Contexts;
using HMS.Infrastructure.Repositories;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;


namespace HMS_API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();

            // ---- Add services ---
            builder.Services.AddDbContext<Context>(options =>
            {
                string connection = @"Data source=DESKTOP-02H8VMC; 
                                    database=HealthManagementSystem; 
                                    Trusted_Connection=true;Encrypt=false; 
                                    TrustServerCertificate=true";
                options.UseSqlServer(connection);
            });

            builder.Services.AddScoped<IPatientApplication, PatientApplication>();
            builder.Services.AddScoped<IPatientRepository, PatientRepository>();
            builder.Services.AddScoped<IPatientService, PatientService>(); //- Sempre q ver um IPatientService,
                                                                           //-- instancia e leva um PatientService
            builder.Services.AddScoped<IEmployeeApplication, EmployeeApplication>();
            builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();
            builder.Services.AddScoped<IEmployeeService, EmployeeService>();
            


            builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
            builder.Services.AddScoped<Context>();


            // ------ Finish -------

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

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
