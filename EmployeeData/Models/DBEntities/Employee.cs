﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeData.Models.DBEntities
{
    public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Column(TypeName ="varchar(50)")]
        public string FirstName {  get; set; }
        public String LastName { get; set; }
        public string DateOfBirth { get; set; }
        public string Email { get; set; }
        public double Salary { get; set; }

    }
}
