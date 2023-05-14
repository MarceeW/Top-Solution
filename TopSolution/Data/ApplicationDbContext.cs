using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TopSolution.Models;

namespace TopSolution.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
#pragma warning disable CS0114 // Member hides inherited member; missing override keyword
        public DbSet<SiteUser> Users { get; set; }
#pragma warning restore CS0114 // Member hides inherited member; missing override keyword
        public DbSet<Topic> Topics { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<SiteUser>()
                .HasMany<Topic>(t => t.Topics)
                .WithOne(t => t.Owner)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<SiteUser>()
                .HasMany<SiteUser>(u => u.FollowedUsers)
                .WithMany();

            builder.Entity<SiteUser>()
                .HasMany<Comment>(c => c.Comments)
                .WithOne()
                .OnDelete(DeleteBehavior.ClientSetNull);

            builder.Entity<Topic>()
                .HasMany<Comment>(c => c.Comments)
                .WithOne(c => c.Topic)
                .OnDelete(DeleteBehavior.Cascade);

            //var topics = Enumerable.Range(0, 130).Select(i => new Topic()
            //{
            //    Title = $"Title {i}",
            //    Description = $"Desc {i}",
            //    RelatedProgLanguages = $"{ProgrammingLanguage.Cpp}",
            //    Type = TopicType.Question,
            //}).ToArray();

            //builder.Entity<Topic>().HasData(topics);

            base.OnModelCreating(builder);
        }
    }
}