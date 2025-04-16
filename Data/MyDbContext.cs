using Microsoft.EntityFrameworkCore;
using techdemo.Controllers;

namespace techdemo.Data;

public class MyDbContext: DbContext
{
    public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
    {
    }
    public DbSet<Student> Students { get; set; }
}