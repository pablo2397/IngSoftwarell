
using DataAccess;
using Entities;
using Microsoft.EntityFrameworkCore;

namespace Concesionario
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddCors();
            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddTransient<IRepositoryBusiness<Vehiculo>, RepositoryBase<Vehiculo>>();
            builder.Services.AddTransient<IRepositoryBusiness<Asesor>, RepositoryBase<Asesor>>();
            builder.Services.AddTransient<IRepositoryBusiness<TipoVehiculo>, RepositoryBase<TipoVehiculo>>();
            builder.Services.AddTransient<IRepositoryBusiness<Departamento>, RepositoryBase<Departamento>>();
            builder.Services.AddTransient<IRepositoryBusiness<Ciudad>,  RepositoryBase<Ciudad>>();

            builder.Services.AddTransient<BusinessRules.Common.IRepositoryBusiness<Vehiculo>, BusinessRules.RepositoryBusiness<Vehiculo>>();
            builder.Services.AddTransient<BusinessRules.Common.IRepositoryBusiness<Asesor>, BusinessRules.RepositoryBusiness<Asesor>>();
            builder.Services.AddTransient<BusinessRules.Common.IRepositoryBusiness<TipoVehiculo>, BusinessRules.RepositoryBusiness<TipoVehiculo>>();
            builder.Services.AddTransient<BusinessRules.Common.IRepositoryBusiness<Departamento>, BusinessRules.RepositoryBusiness<Departamento>>();
            builder.Services.AddTransient<BusinessRules.Common.IRepositoryBusiness<Ciudad>, BusinessRules.RepositoryBusiness<Ciudad>>();
            builder.Configuration.AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            string conexionString = builder.Configuration.GetConnectionString("ConcesionarioDb")!;
            builder.Services.AddDbContext<ConcesionarioContext>(Db =>
            {
                Db.UseSqlServer(conexionString);
                Db.UseLazyLoadingProxies();
            });
            var app = builder.Build();
            app.UseCors(b => b.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());
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
