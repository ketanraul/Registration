using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace User_Reg_MVC_Core.Models
{
    public class UserClass
    {
        [Key]
        public int UserId { get; set; }
        [Required(ErrorMessage ="Please Enter Username")]
        [Display(Name ="User Name")]

        public string UserName { get; set; }
        [Required(ErrorMessage = "Please Enter password")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]

        public string Pwd { get; set; }
        [Required(ErrorMessage = "Please Enter Confirm Password")]
        [DataType(DataType.Password)]
        [Display(Name = "confirm Password")]
        [Compare("Pwd")]
        public string ConfirmPwd { get; set; }

        [Required(ErrorMessage = "Please Enter Email Address")]
        [Display(Name = "EMail Address")]
        public string Uemail { get; set; }
        [Required(ErrorMessage = "Please Enter Gender")]
        [Display(Name = "Gender")]
        public string Gender { get; set; }
        

        public string Maritalstatus { get; set; }
         }
}
