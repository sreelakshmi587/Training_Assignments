//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVCRegistrationForm1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Register_details
    {
        public int RegisterId { get; set; }

        [Required(AllowEmptyStrings =false,ErrorMessage ="Please fill your First Name")]
        [MinLength(2,ErrorMessage ="The name should have atleast two characters")]
        [MaxLength(20)]
        public string FirstName { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Please fill your Middle Name")]
        public string MiddleName { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Please fill your Last Name")]
        public string LastName { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Please fill your Age")]
        public int Age { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Please provide your Email id")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Please provide your Phone number")]
        [MinLength(10, ErrorMessage = "Phone number should have atleast ten digits")]
        [MaxLength(12)]
        public string PhoneNumber { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Please fill your Contact Address")]
        [DataType(DataType.Text)]
        public string Address { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Please fill your Pincode")]
        [MinLength(4, ErrorMessage = "Pincode should have atleast four digits")]
        public string Pincode { get; set; }
        public string Created_by { get; set; }

       
        public DateTime Created_at { get ; set; }
    }
}
