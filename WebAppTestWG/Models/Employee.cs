

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebAppTestWG.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [DisplayName("Manager")]
        public int? ManagerId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public Position Position { get; set; }
        public Division Division { get; set; }
        public virtual Employee Manager { get; set; }
    }
}