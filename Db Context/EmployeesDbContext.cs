using Microsoft.EntityFrameworkCore;
using time_sheet.Db_Classes;
using time_sheet.Other_Classes;

namespace time_sheet.Db_Contexts
{
    public class EmployeesDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(DataSource.ReadDataSourceStringFromFile(), ServerVersion.AutoDetect(DataSource.DataSourceString));
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Employee>().ToTable("Employee");
            modelBuilder.Entity<Employee>().Property(e => e.Id).ValueGeneratedOnAdd();
            modelBuilder.Entity<Employee>().Property(e => e.Name).HasConversion<string>();
            modelBuilder.Entity<Employee>().Property(e => e.SecondName).HasConversion<string>();
            modelBuilder.Entity<Employee>().Property(e => e.SurName).HasConversion<string>();
            modelBuilder.Entity<Employee>().Property(e => e.Position).HasConversion<string>();
            modelBuilder.Entity<Employee>().Property(e => e.ResidenceAddress).HasConversion<string>();
        }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Departament> Departament { get; set; }
        public DbSet<Year> Year { get; set; }
        public DbSet<DayInYear> Day { get; set; }
        public DbSet<Mark> Mark { get; set; }

    }
}
