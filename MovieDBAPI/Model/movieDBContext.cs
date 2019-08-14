using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MovieDBAPI.Model
{
    public partial class movieDBContext : DbContext
    {
        public movieDBContext()
        {
        }

        public movieDBContext(DbContextOptions<movieDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Movie> Movie { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=tcp:phase2server.database.windows.net,1433;Initial Catalog=movieDB;Persist Security Info=False;User ID=csim724;Password=Yui@12345;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<Movie>(entity =>
            {
                entity.Property(e => e.ImdbId).IsUnicode(false);

                entity.Property(e => e.MovieDetail).IsUnicode(false);

                entity.Property(e => e.MoviePoster).IsUnicode(false);

                entity.Property(e => e.MovieSummary).IsUnicode(false);

                entity.Property(e => e.MovieTitle).IsUnicode(false);
            });
        }
    }
}
