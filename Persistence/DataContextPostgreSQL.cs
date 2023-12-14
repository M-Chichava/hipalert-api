using Microsoft.EntityFrameworkCore;

namespace Persistence;

public class DataContextPostgreSQL : DataContext 
{
    public DataContextPostgreSQL(DbContextOptions options) : base(options)
    {
        
    }

    protected void onModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}