using Microsoft.EntityFrameworkCore;
using API.Entities;
namespace API.Data;

public class DataContext : DbContext
{
  protected readonly IConfiguration Configuration;

    public DataContext(IConfiguration configuration)
    {
        Configuration = configuration;
    }
     protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        // connect to sqlite database
        options.UseSqlite(Configuration.GetConnectionString("DefaultConnection"));
    }
    public DbSet<AppUser> Users { get; set; }
}

