using Microsoft.EntityFrameworkCore;
using VerlofSysteem.Models;

namespace VerlofSysteem.Context;

public class VerlofDbContext : DbContext
{
    
    public VerlofDbContext(DbContextOptions<VerlofDbContext> options) : base(options)
    {
        
    }
    
    public DbSet<Verlof> Verlofs { get; set; }
}