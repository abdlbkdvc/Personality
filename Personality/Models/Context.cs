using Microsoft.EntityFrameworkCore;

namespace Personality.Models
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.\\SQLEXPRESS; database=Personality; integrated security=true; TrustServerCertificate=true");
        }
        public DbSet<Person> Persons { get; set; }
        public DbSet<MyService> MyServices { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Faruk> Faruks{ get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>()
                     .HasMany(p => p.MyServices)
                     .WithMany(s => s.Person)
                     .UsingEntity<Dictionary<string, object>>(
                         "PersonServices", // Ara tablonun adı
                         j => j.HasOne<MyService>().WithMany().HasForeignKey("MyServiceId"),
                         j => j.HasOne<Person>().WithMany().HasForeignKey("PersonId")
                     );

        }
    }
}
