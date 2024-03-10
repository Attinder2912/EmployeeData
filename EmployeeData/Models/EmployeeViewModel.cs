using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeData.Models
{
    public class EmployeeViewModel
    {
        public int Id { get; set; }
        [DisplayName("First Name")]
        public string FirstName { get; set; }
        [DisplayName("Last Name")]
        public String LastName { get; set; }
        [DisplayName("Date of Birth")]
        public string DateOfBirth { get; set; }
        [DisplayName("E-mail")]
        public string Email { get; set; }
        public double Salary { get; set; }
        [DisplayName("Name")]
        public string FullName
        {
             get{ return FirstName + "" + LastName; }
        }
    }
}
