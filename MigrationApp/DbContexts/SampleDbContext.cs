using Microsoft.EntityFrameworkCore;
using MigrationApp.Entities;

namespace MigrationApp.DbContexts
{
    // コンテキストクラス
    public class SampleDbContext : DbContext
    {
        public SampleDbContext(DbContextOptions<SampleDbContext> options) : base(options) { }
        public DbSet<Blog> Blog { get; set; }
    }
}
