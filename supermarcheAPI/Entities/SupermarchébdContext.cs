using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace supermarcheAPI.Entities;

public partial class SupermarchébdContext : DbContext
{
    public SupermarchébdContext()
    {
    }

    public SupermarchébdContext(DbContextOptions<SupermarchébdContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Article> Articles { get; set; }

    public virtual DbSet<Categorie> Categories { get; set; }

    public virtual DbSet<Vendeur> Vendeurs { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySQL("server=localhost;port=3306;user=root;password=;database=supermarchébd");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Article>(entity =>
        {
            entity.HasKey(e => e.Artcode).HasName("PRIMARY");

            entity.ToTable("article");

            entity.HasIndex(e => e.ArtCat, "ArtCat");

            entity.Property(e => e.Artcode).HasColumnType("int(11)");
            entity.Property(e => e.ArtCat)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("int(11)");
            entity.Property(e => e.ArtDateexpi)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("date");
            entity.Property(e => e.ArtNom).HasMaxLength(255);
            entity.Property(e => e.ArtPrix).HasPrecision(10);
            entity.Property(e => e.ArtQte)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("int(11)");

            entity.HasOne(d => d.ArtCatNavigation).WithMany(p => p.Articles)
                .HasForeignKey(d => d.ArtCat)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("article_ibfk_1");
        });

        modelBuilder.Entity<Categorie>(entity =>
        {
            entity.HasKey(e => e.Catcode).HasName("PRIMARY");

            entity.ToTable("categorie");

            entity.Property(e => e.Catcode).HasColumnType("int(11)");
            entity.Property(e => e.CatNom).HasMaxLength(255);
            entity.Property(e => e.CatRemarque)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'");
        });

        modelBuilder.Entity<Vendeur>(entity =>
        {
            entity.HasKey(e => e.Vendcode).HasName("PRIMARY");

            entity.ToTable("vendeurs");

            entity.Property(e => e.Vendcode).HasColumnType("int(11)");
            entity.Property(e => e.VendAdresse)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'");
            entity.Property(e => e.VendNom).HasMaxLength(255);
            entity.Property(e => e.VendPhone)
                .HasMaxLength(20)
                .HasDefaultValueSql("'NULL'");
            entity.Property(e => e.VendPseudo).HasMaxLength(50);
            entity.Property(e => e.VendmotPass).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
