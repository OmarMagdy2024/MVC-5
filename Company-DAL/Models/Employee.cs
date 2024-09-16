using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Company_DAL.Models
{
    public enum Gender
    {
        [EnumMember(Value ="Male")]
        Male=1,
        [EnumMember(Value = "Female")]
        Female=2
    }
    public class Employee:ModelBase
    {
        //public int Id { get; set; }

        [Required(ErrorMessage = "Name Is Required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Salary Is Required")]
        public double Salary { get; set; }

        [Required(ErrorMessage = "HiringDate Is Required")]
        [Display(Name = "Hiring Date")]

        public DateTime HiringDate { get; set; }

        public string Address { get; set; }

        [Range(21,60)]
        public int Age { get; set; }

        [Phone]
        public string Phone {  get; set; }

        public Gender Gender { get; set; }

        [EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage = "DepartmentId Is Required")]

        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }

        //[InverseProperty(nameof(Models.Department.Employess))]
        public Department Department { get; set; }
        public int? DepartmentId { get; set; }
    }
}
