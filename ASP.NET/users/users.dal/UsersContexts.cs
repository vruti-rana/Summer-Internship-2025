using Microsoft.EntityFrameworkCore;
using Users.Core.Models;

namespace Users.DAL
{
    public class UsersContext : DbContext
    {
        public UsersContext(DbContextOptions<UsersContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
    }
}
