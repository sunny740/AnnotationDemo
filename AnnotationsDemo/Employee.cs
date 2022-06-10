using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnotationsDemo
{
    public class Employee
    {
        [Required(ErrorMessage = "Id Should be Mandatory")]
        public int Id { get; set; }
        [Required(ErrorMessage = "Employee {0} is Required")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Name Should be above 3 Char")]
        [DataType(DataType.Text)]
        public string Name { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Range(18, 99, ErrorMessage = "Age Should Be Above 18")]
        public int Age { get; set; }
        [DataType(DataType.PhoneNumber)]
        public long MobileNumber { get; set; }
    }
}