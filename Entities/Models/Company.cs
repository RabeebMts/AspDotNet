using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Models
{
   public class Company
    {
        [Column("CompanyId")] //Name in Database
        [Key] //It's Primary Key if there is column with ID suffix this mean it's a primary key and you can ingone this notation
        public Guid GId { get; set; }

        [MaxLength(50, ErrorMessage = "Maximam Company Name Lenght is 50")]
        [Required(ErrorMessage = "Company Name is Required Field")]
        public string Name { get; set; }

        [MaxLength(100, ErrorMessage = "Maximam Company Address Lenght is 100")]
        [Required(ErrorMessage = "Company Address is Required Field")]
        public string Address { get; set; }

        [MaxLength(30, ErrorMessage = "Maximam Company Country Lenght is 30")]
        public string Country { get; set; }

        public ICollection<Employee> Employees { get; set; }
    }
}
