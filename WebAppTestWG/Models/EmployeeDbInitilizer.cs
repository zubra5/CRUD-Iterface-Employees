using System.Data.Entity;

namespace WebAppTestWG.Models
{
    public class EmployeeDbInitilizer : DropCreateDatabaseAlways<EmployeeContext>
    {
        protected override void Seed(EmployeeContext context)
        {
            context.Employees.Add(new Employee() { Id = 1, FirstName = "John", MiddleName = "Von", LastName = "Smith", Position = Position.Engineer, Division = Division.Development});
            context.Employees.Add(new Employee() { Id = 2, FirstName = "Mark", MiddleName = "Lord", LastName = "Twain", Position = Position.Engineer, Division = Division.Testing });
            base.Seed(context);
        }
    }
}