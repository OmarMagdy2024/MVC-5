using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company_DAL.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name Is Required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Salary Is Required")]
        public double Salary { get; set; }

        [Required(ErrorMessage = "HiringDate Is Required")]
        [Display(Name = "Hiring Date")]

        public DateTime HiringDate { get; set; }

        [Required(ErrorMessage = "DepartmentId Is Required")]
        public int DepartmentId { get; set; }
    }
}
