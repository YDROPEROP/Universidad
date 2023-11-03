using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Universidad.DAL.DataContext;

public partial class UniversidadContext : DbContext
{
    public UniversidadContext()
    {
    }

    public UniversidadContext(DbContextOptions<UniversidadContext> options)
        : base(options)
    {
    }

    public virtual DbSet<CoursStudent> CoursStudents { get; set; }

    public virtual DbSet<Course> Courses { get; set; }

    public virtual DbSet<Qualification> Qualifications { get; set; }

    public virtual DbSet<Student> Students { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=(local); DataBase=Universidad;Integrated Security=true; Trusted_Connection=True; TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CoursStudent>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CoursStu__3214EC0775C78D3E");

            entity.ToTable("CoursStudent");

            entity.Property(e => e.FechaCreacion)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

            entity.HasOne(d => d.Course).WithMany(p => p.CoursStudents)
                .HasForeignKey(d => d.CourseId)
                .HasConstraintName("FK__CoursStud__Cours__440B1D61");

            entity.HasOne(d => d.Student).WithMany(p => p.CoursStudents)
                .HasForeignKey(d => d.StudentId)
                .HasConstraintName("FK__CoursStud__Stude__4316F928");
        });

        modelBuilder.Entity<Course>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Courses__3214EC07F0966046");

            entity.Property(e => e.Names)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.HasOne(d => d.Qualifications).WithMany(p => p.Courses)
                .HasForeignKey(d => d.QualificationsId)
                .HasConstraintName("FK__Courses__Qualifi__398D8EEE");
        });

        modelBuilder.Entity<Qualification>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Qualific__3214EC076650CAF8");

            entity.Property(e => e.Nota)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Student>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Students__3214EC07CE08C4FE");

            entity.Property(e => e.Addres).HasMaxLength(255);
            entity.Property(e => e.Descripcion).HasMaxLength(255);
            entity.Property(e => e.Email).HasMaxLength(255);
            entity.Property(e => e.FechaCreacion)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.FechaModificacion).HasColumnType("datetime");
            entity.Property(e => e.FirstName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.LasName).HasMaxLength(255);

            entity.HasOne(d => d.Courses).WithMany(p => p.Students)
                .HasForeignKey(d => d.CoursesId)
                .HasConstraintName("FK__Students__Course__3F466844");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
