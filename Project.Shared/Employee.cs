using System;
using System.ComponentModel.DataAnnotations;

namespace Project.Shared
{
    public class Employee
    {
       
        public int EmployeeId { get; set; }

        [Required]
        public String Name { get; set; }

        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime DateOfBirth { get; set; }

        [Display(Name = "Email Address")]
        [Required(ErrorMessage = "The email address is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        
        public string Email { get; set; }


       
        [Display(Name = "Phone Number")]
        [Required(ErrorMessage = "Phone Number Required!")]
        //[RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$",
        //           ErrorMessage = "Entered phone format is not valid.")]


        public string PhoneNumber { get; set; }


         public int Sid { get; set; }
       // public Status Status { get; set; }
       // public int DepartmentId { get; set; }
       // public Department Department { get; set; }

    }
}
