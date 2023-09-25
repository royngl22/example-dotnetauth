using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DotnetAuthExample.AuthExampleDBContext
{
    public partial class AuthExampleContext : DbContext
    {
        public AuthExampleContext()
        {
        }

        public AuthExampleContext(DbContextOptions<AuthExampleContext> options)
            : base(options)
        {
        }

        public virtual DbSet<UserTbl> UserTbls { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Name=ConnectionStrings:AuthExampleDB");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserTbl>(entity =>
            {
                entity.HasKey(e => e.Email)
                    .HasName("PK__UserTbl__A9D10535812AD738");

                entity.ToTable("UserTbl");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreateBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Password).IsUnicode(false);

                entity.Property(e => e.Role)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('admin')");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
