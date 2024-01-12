using App.Context.Models;
using Microsoft.EntityFrameworkCore;

namespace App.Context;

public class AppContext : DbContext
{
    public AppContext(DbContextOptions<AppContext> options) : base(options)
    {
    }
    
    public DbSet<Login> Logins { get; set; }
    public DbSet<Inquiry> Inquiries { get; set; }
}