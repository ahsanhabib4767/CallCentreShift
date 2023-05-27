using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace OBL.BIC.Model
{
    public partial class TestContext : DbContext
    {
        public TestContext()
        {
        }

        public TestContext(DbContextOptions<TestContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AccBicUser> AccBicUsers { get; set; } = null!;
        public virtual DbSet<Employee> Employees { get; set; } = null!;
        public virtual DbSet<EmployeeShift> EmployeeShifts { get; set; } = null!;
        public virtual DbSet<Manager> Managers { get; set; } = null!;
        public virtual DbSet<NonWorkingDay> NonWorkingDays { get; set; } = null!;
        public virtual DbSet<ShiftTiming> ShiftTimings { get; set; } = null!;
        public virtual DbSet<WeekDay> WeekDays { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("server=localhost\\sqlexpress; Initial Catalog=Test;Trusted_Connection=true;MultipleActiveResultSets=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AccBicUser>(entity =>
            {
                entity.ToTable("AccBicUser");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATED_ON");

                entity.Property(e => e.Empbranchcode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EMPBRANCHCODE");

                entity.Property(e => e.Employeeid)
                    .HasMaxLength(50)
                    .HasColumnName("EMPLOYEEID");

                entity.Property(e => e.Employeename)
                    .HasMaxLength(50)
                    .HasColumnName("EMPLOYEENAME");

                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("MODIFIED_ON");

                entity.Property(e => e.Usertype)
                    .HasMaxLength(50)
                    .HasColumnName("USERTYPE");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.ToTable("Employee");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.EmpIdentity)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Gender)
                    .HasMaxLength(50)
                    .IsUnicode(false);
                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATED_ON");

                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");

                entity.Property(e => e.Usertype)
                    .HasMaxLength(50)
                    .HasColumnName("USERTYPE");

                entity.Property(e => e.ManagerId).HasColumnName("ManagerID");

                entity.HasOne(d => d.Manager)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.ManagerId)
                    .HasConstraintName("FK_Employee_Manager");
            });

            modelBuilder.Entity<EmployeeShift>(entity =>
            {
                entity.ToTable("EmployeeShift");

                entity.Property(e => e.EmployeeShiftId).HasColumnName("EmployeeShiftID");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.ShiftDate).HasColumnType("date");

                entity.Property(e => e.ShiftTimingId).HasColumnName("ShiftTimingID");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.EmployeeShifts)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK_EmployeeShift_Employee");

                entity.HasOne(d => d.ShiftTiming)
                    .WithMany(p => p.EmployeeShifts)
                    .HasForeignKey(d => d.ShiftTimingId)
                    .HasConstraintName("FK_EmployeeShift_ShiftTiming");
            });

            modelBuilder.Entity<Manager>(entity =>
            {
                entity.ToTable("Manager");

                entity.Property(e => e.ManagerId).HasColumnName("ManagerID");

                entity.Property(e => e.ManagerName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<NonWorkingDay>(entity =>
            {
                entity.ToTable("NonWorkingDay");

                entity.Property(e => e.NonWorkingDayId).HasColumnName("NonWorkingDayID");

                entity.Property(e => e.HoliDayName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NonWorkingDate).HasColumnType("date");
            });

            modelBuilder.Entity<ShiftTiming>(entity =>
            {
                entity.ToTable("ShiftTiming");

                entity.Property(e => e.ShiftTimingId).HasColumnName("ShiftTimingID");

                entity.Property(e => e.ShiftCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShiftName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WeekDay>(entity =>
            {
                entity.HasKey(e => e.WeekId)
                    .HasName("PK__WeekDays__C814A5E1200AF9E1");

                entity.Property(e => e.WeekId).HasColumnName("WeekID");

                entity.Property(e => e.WeekEndTime).HasColumnType("date");

                entity.Property(e => e.WeekStartDate).HasColumnType("date");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
