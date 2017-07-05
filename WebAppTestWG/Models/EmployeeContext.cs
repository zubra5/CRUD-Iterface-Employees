using System.Data.Entity;


namespace WebAppTestWG.Models
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext()
            : base("EmployeeConnection")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
                .HasOptional(v => v.Manager)
                .WithMany()
                .HasForeignKey(v => v.ManagerId);
           
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Employee> Employees { get; set; }
    }
}