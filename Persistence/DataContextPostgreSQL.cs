using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class DataContextPostgreSQL : DataContext
    {

        //PostGreSQL Data Context
        public DataContextPostgreSQL(DbContextOptions<DataContextPostgreSQL> options) : base(options)
        {
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}