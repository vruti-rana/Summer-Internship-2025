using Microsoft.EntityFrameworkCore;
using Users.DAL;
using Users.Core.Interfaces;
using Users.DAL.Repositories;
using Users.BLL.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container

// Register DbContext
builder.Services.AddDbContext<UsersContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

// Register repository
builder.Services.AddScoped<IUserRepository, UserRepository>();

// Register service
builder.Services.AddScoped<IUserService, UserService>();

// Add controllers and swagger
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure HTTP pipeline
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();
app.MapControllers();
app.Run();
