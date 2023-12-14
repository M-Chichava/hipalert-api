using Microsoft.EntityFrameworkCore;
using Persistence;

namespace API.Extensions;

public class DBServiceExtension
{
    public class DataBaseSetting
    {
        public string DataBaseType { get; set; }
    }
    public static IConfiguration Configuration { get; set; }

    public static IServiceCollection AddDataBaseService( IServiceCollection service,
        IConfiguration configuration)
    {
        Configuration = configuration;
        var dataBaseSection = Configuration.GetSection("DataBase");
        service.Configure<DataBaseSetting>(dataBaseSection);

        service.AddDbContext<DataContext, DataContextPostgreSQL>(ConfigurePostgreSQL);
        return service;
    }

    private static void ConfigurePostgreSQL(DbContextOptionsBuilder options)
    {
        string postgreSQLConnectionString = Configuration.GetConnectionString("PostGreSQLConnectionString");
        options.UseNpgsql(postgreSQLConnectionString);
        options.EnableSensitiveDataLogging(false);
    }
}

