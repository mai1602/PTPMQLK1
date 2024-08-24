using System.ComponentModel.DataAnnotations;
namespace DemoMVC.Models
{
    public class Employee
    {
        [KeyAttribute]
        public string EmployeeId { get; set; }
        public int Age { get; set; }
        public string PersonId { get; set; }
        public string FullName { get; set; }




    }
}