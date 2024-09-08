using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company_DAL.Models
{
    public class Department
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Name Is Required")]
        public string Name { get; set; }


        [Required(ErrorMessage ="DateOfCreation Is Required")]
        [Display(Name = "Date Of Creation")]
        public DateTime DateOfCreation { get; set; }
    }
}
