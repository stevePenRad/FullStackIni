using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistance
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Section> Sections { get; set; }
        public DbSet<BooleanSetting> BooleanSettings { get; set; }
        public DbSet<IntegerSetting> IntegerSettings { get; set; }
        public DbSet<StringSetting> StringSettings { get; set; }
    }
}