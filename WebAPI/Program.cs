using Microsoft.EntityFrameworkCore;
using WebAPI.Data;

namespace WebAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);


            var mariaDbVersion = new MySqlServerVersion(new Version(5, 7));

            builder.Services.AddDbContextFactory<ApplicationDbContext>(options =>
            {
                options.UseMySql($"server={Environment.GetEnvironmentVariable("MARIADB_BASE_ADDRESS")};port=3306;user=root;password={Environment.GetEnvironmentVariable("MARIADB_ROOT_PASSWORD")};database={Environment.GetEnvironmentVariable("MARIADB_DATABASE")}", mariaDbVersion);
            });

            // Add services to the container.

            builder.Services.AddControllers();
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
        }
    }
}