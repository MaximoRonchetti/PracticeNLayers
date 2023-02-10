using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Models.Data
{
    public partial class PracticeNLayersContext : DbContext
    {
        public PracticeNLayersContext()
        {
        }

        public PracticeNLayersContext(DbContextOptions<PracticeNLayersContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Departament> Departaments { get; set; } = null!;
        public virtual DbSet<Employee> Employees { get; set; } = null!;
        public virtual DbSet<EmployeeProject> EmployeeProjects { get; set; } = null!;
        public virtual DbSet<Project> Projects { get; set; } = null!;
        public virtual DbSet<Sprint> Sprints { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=localhost;Database=PracticeNLayers;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Departament>(entity =>
            {
                entity.ToTable("Departament");

                entity.Property(e => e.Description).HasMaxLength(50);
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.ToTable("Employee");

                entity.Property(e => e.DateOfBirth).HasColumnType("datetime");

                entity.Property(e => e.IdNumber).HasMaxLength(50);

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.HasOne(d => d.Departament)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.DepartamentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Employee_Departament");
            });

            modelBuilder.Entity<EmployeeProject>(entity =>
            {
                entity.ToTable("Employee_Project");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.EmployeeProjects)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Employee_Project_EmployeeId");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.EmployeeProjects)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Employee_Project_ProjectId");
            });

            modelBuilder.Entity<Project>(entity =>
            {
                entity.ToTable("Project");

                entity.Property(e => e.Budget).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Title).HasMaxLength(50);
            });

            modelBuilder.Entity<Sprint>(entity =>
            {
                entity.ToTable("Sprint");

                entity.Property(e => e.DateFinish).HasColumnType("datetime");

                entity.Property(e => e.DateInit).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.PercentComplete).HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.Sprints)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Sprint_Project");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
