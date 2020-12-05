using ArticleApp.Models.Users;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace ArticleApp.Models
{
    public class ArticleAppDBContext : DbContext
    {
        public ArticleAppDBContext()
        {
            //empty
        }
        public ArticleAppDBContext(DbContextOptions<ArticleAppDBContext> options)
            : base(options)
        {
            // 공식과 같은 코드
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                string connectionString = ConfigurationManager.ConnectionStrings
                    ["ConnectionString"].ConnectionString;
                optionsBuilder.UseSqlServer(connectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Article>().Property(m => m.Created).HasDefaultValueSql("GetDate()");
            modelBuilder.Entity<User>().Property(m => m.Created).HasDefaultValueSql("GetDate()");
        }

        public DbSet<Article> Articles { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
