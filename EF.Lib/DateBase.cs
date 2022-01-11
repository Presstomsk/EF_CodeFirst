
using EF.Model;
using Microsoft.EntityFrameworkCore;
using System.IO;

namespace EF.Lib
{
    public class DateBase : DbContext
    {
        public static string connectionStringFile = "/ConnectionString.txt";
        public DbSet<Game> TabGames { get; set; }

        protected DateBase() { }
        public DateBase(DbContextOptions<DateBase> options) : base(options)
        {
            Database.EnsureCreated();
        }
        public static DateBase Init()
        {
            var options = new DbContextOptionsBuilder<DateBase>().UseMySQL(unt).Options;
            return new DateBase(options);
        }

        protected static string GetConnectionString()
        {
            var streamReader = new StreamReader(Directory.GetCurrentDirectory() + connectionStringFile);
            return streamReader.ReadToEnd();
        }

    }
}
