using MVC_Demo.Models;
using Microsoft.EntityFrameworkCore;

namespace MVC_Demo.Data;

public class ApplicationDbContext : DbContext
{
    public DbSet<Job> Jobs{ get; set; } = default!;
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
        
    }
}
