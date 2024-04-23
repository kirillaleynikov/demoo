using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WinFormsApp2.Models
{
    public partial class ServisDBContext : DbContext
    {
        public ServisDBContext()
        {
        }

        public ServisDBContext(DbContextOptions<ServisDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ModelTechn> ModelTechns { get; set; } = null!;
        public virtual DbSet<Order> Orders { get; set; } = null!;
        public virtual DbSet<Report> Reports { get; set; } = null!;
        public virtual DbSet<Role> Roles { get; set; } = null!;
        public virtual DbSet<Status> Statuses { get; set; } = null!;
        public virtual DbSet<TypeBtTechn> TypeBtTechns { get; set; } = null!;
        public virtual DbSet<TypeProblem> TypeProblems { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;
        public virtual DbSet<ZapAndOrder> ZapAndOrders { get; set; } = null!;
        public virtual DbSet<Zapchasti> Zapchastis { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=LAPTOP-VJAV0JCF;Database=ServisDB;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ModelTechn>(entity =>
            {
                entity.ToTable("ModelTechn");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Titel).HasColumnName("titel");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Comment).HasColumnName("comment");

                entity.Property(e => e.DateCreate)
                    .HasColumnType("date")
                    .HasColumnName("dateCreate");

                entity.Property(e => e.IdClient).HasColumnName("idClient");

                entity.Property(e => e.IdWorcker).HasColumnName("idWorcker");

                entity.Property(e => e.Idnumber).HasColumnName("idnumber");

                entity.Property(e => e.ModelId).HasColumnName("modelId");

                entity.Property(e => e.PhoneNumber).HasColumnName("phoneNumber");

                entity.Property(e => e.StatusId).HasColumnName("statusId");

                entity.Property(e => e.TypeBtTechnId).HasColumnName("typeBtTechnId");

                entity.Property(e => e.TypeProblem).HasColumnName("typeProblem");

                entity.HasOne(d => d.IdClientNavigation)
                    .WithMany(p => p.OrderIdClientNavigations)
                    .HasForeignKey(d => d.IdClient)
                    .HasConstraintName("FK__Orders__idClient__45F365D3");

                entity.HasOne(d => d.IdWorckerNavigation)
                    .WithMany(p => p.OrderIdWorckerNavigations)
                    .HasForeignKey(d => d.IdWorcker)
                    .HasConstraintName("FK__Orders__idWorcke__47DBAE45");

                entity.HasOne(d => d.Model)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.ModelId)
                    .HasConstraintName("FK_Orders_ModelTechn");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK__Orders__statusId__46E78A0C");

                entity.HasOne(d => d.TypeBtTechn)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.TypeBtTechnId)
                    .HasConstraintName("FK__Orders__typeBtTe__440B1D61");

                entity.HasOne(d => d.TypeProblemNavigation)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.TypeProblem)
                    .HasConstraintName("FK_Orders_TypeProblem");
            });

            modelBuilder.Entity<Report>(entity =>
            {
                entity.ToTable("Report");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DateFinish)
                    .HasColumnType("date")
                    .HasColumnName("dateFinish");

                entity.Property(e => e.Descript).HasColumnName("descript");

                entity.Property(e => e.OrderId).HasColumnName("orderId");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.Reports)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("FK__Report__orderId__4AB81AF0");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Titel).HasColumnName("titel");
            });

            modelBuilder.Entity<Status>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Titel).HasColumnName("titel");
            });

            modelBuilder.Entity<TypeBtTechn>(entity =>
            {
                entity.ToTable("TypeBtTechn");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Titel).HasColumnName("titel");
            });

            modelBuilder.Entity<TypeProblem>(entity =>
            {
                entity.ToTable("TypeProblem");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Title)
                    .HasMaxLength(100)
                    .HasColumnName("title");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.LoginU).HasColumnName("loginU");

                entity.Property(e => e.Number).HasColumnName("number");

                entity.Property(e => e.PasswordU).HasColumnName("passwordU");

                entity.Property(e => e.RoleId).HasColumnName("roleId");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK__Users__roleId__412EB0B6");
            });

            modelBuilder.Entity<ZapAndOrder>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Counts).HasColumnName("counts");

                entity.Property(e => e.ReportsId).HasColumnName("reportsId");

                entity.HasOne(d => d.Reports)
                    .WithMany()
                    .HasForeignKey(d => d.ReportsId)
                    .HasConstraintName("FK__ZapAndOrd__repor__4D94879B");

                entity.HasOne(d => d.Zap)
                    .WithMany()
                    .HasForeignKey(d => d.ZapId)
                    .HasConstraintName("FK__ZapAndOrd__ZapId__4CA06362");
            });

            modelBuilder.Entity<Zapchasti>(entity =>
            {
                entity.ToTable("Zapchasti");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Titel).HasColumnName("titel");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
