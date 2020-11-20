using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Models
{
    public class Employee
    {
        [Column("EmployeeId")] //Name in Database
        [Key] //It's Primary Key if there is column with ID suffix this mean it's a primary key and you can ingone this notation
        public Guid GId { get; set; }

        [Required(ErrorMessage = "Employee Name is Required Field")]
        [MaxLength(50, ErrorMessage = "Maximam Employee Name Lenght is 50")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Employee Position is Required Field")]
        [MaxLength(40, ErrorMessage = "Maximam Employee Position Lenght is 40")]
        public string Position { get; set; }


        [Required(ErrorMessage = "Employee Age is Required Field")]
        public int Age { get; set; }

        /*   Link Employee with Company  */
        [ForeignKey(nameof(Company))]
        public Guid CompanyID { get; set; }
        public Company Company { get; set; }


        /*   Link each Employee with his manager 
        [ForeignKey(nameof(Employee))]
        public Guid ManagerID { get; set; }
        public Employee Manager { get; set; } */
    }
}
