
using Books.DataAccess;
using Books.DataAccess.Repositories;
using Books.Services.Services;
using Microsoft.EntityFrameworkCore;

namespace Book_Management
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            builder.Services.AddDbContext<BooksDbContext>(db => db.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));
            builder.Services.AddScoped<BooksService>();
            builder.Services.AddScoped<BooksRepository>();
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
