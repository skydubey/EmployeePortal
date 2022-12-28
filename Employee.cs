using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PracticeMVC14.Models
{
    public class Employee
    {
        [Required (ErrorMessage = "The Employee Id is mandatory.")]
        public int EmpId { get; set; }


        [Required (ErrorMessage = "The Employee Name is mandatory.")]
        [StringLength(25,MinimumLength = 10,ErrorMessage ="Name should be in between 10 & 25.")]
        public string EmpName { get; set; }
        
        [Required (ErrorMessage = "The Employee Mobile is mandatory.")]
        [RegularExpression("^([0-9]{10})$", ErrorMessage = "Invalid Mobile Number.")]
        public string EmpMobile { get; set; }


        [Required (ErrorMessage = "The Employee Age is mandatory.")]
        [Range(18, 30,ErrorMessage ="Age must be between 18 to 30")]
        public int? EmpAge { get; set; }


        [Required (ErrorMessage = "The Employee Gender is mandatory.")]
        public string EmpGender { get; set; }



        [Required (ErrorMessage = "The Employee Email is mandatory.")]
        [RegularExpression("^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$",ErrorMessage ="Email is Invalid")]
        public string EmpEmail { get; set; }



        [Required (ErrorMessage = "The Employee Password is mandatory.")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[$@$!%*?&])[A-Za-z\d$@$!%*?&]{8,}", ErrorMessage ="Password is Invalid")]
        [DataType(DataType.Password)]
        public string EmpPassword { get; set; }



        [Required (ErrorMessage = "The Confirm Password is mandatory.")]
        [Compare("EmpPassword",ErrorMessage ="Password & Confirm Password does not match.")]
        public string EmpConfirmPassword { get; set; }



        [ReadOnly(true)]
        public string EmpOrganisationName { get; set; }



        [Required (ErrorMessage = "The Employee Address is mandatory.")]
        [StringLength(100, MinimumLength = 25, ErrorMessage = "Address should be in between 25 & 100")]
        [DataType(DataType.MultilineText)]
        public string EmpAddress { get; set; }




        [Required (ErrorMessage = "The Employee Joining Date is mandatory.")]
        [DataType(DataType.Date)]
        public string EmpJoiningDate { get; set; }



        /*[Required (ErrorMessage = "The Employee Joining Time is mandatory.")]
        [DataType(DataType.Time)]
        public string EmpJoiningTime { get; set; }*/



        [Required(ErrorMessage = "The Employee Country is mandatory.")]
        public string EmpCountry { get; set; }



    }
   
}