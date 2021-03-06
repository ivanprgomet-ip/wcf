namespace L04E02.Books.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class BooksEntities : DbContext
    {
        public BooksEntities()
            : base("name=BooksCS")
        {
        }

        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<Store> Stores { get; set; }
        public virtual DbSet<Title> Titles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>()
                .HasMany(e => e.Titles)
                .WithMany(e => e.Authors)
                .Map(m => m.ToTable("AuthorISBN").MapLeftKey("AuthorID").MapRightKey("ISBN"));
        }
    }
}
