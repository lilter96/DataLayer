

using FictionDataLayer.Entity;
using Microsoft.EntityFrameworkCore;

namespace FictionDataLayer
{
    class ApplicationDbContext : DbContext
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<Fanfic> Fanfics { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Medal> Medals { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Rating> Ratings { get; set; }
        public DbSet<Chapter> Chapters { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            //Database.EnsureDeleted();
            //Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<FanficTags>()
                .HasKey(t => new { t.FanficId, t.TagId });
            builder.Entity<FanficTags>()
                .HasOne(sc => sc.Fanfic)
                .WithMany(s => s.FanficTags)
                .HasForeignKey(sc => sc.FanficId);
            builder.Entity<FanficTags>()
                .HasOne(sc => sc.Tag)
                .WithMany(s => s.FanficTags)
                .HasForeignKey(sc => sc.TagId);
        }
    }
}
