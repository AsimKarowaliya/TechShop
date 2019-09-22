using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TechShop.Models
{
    public class SignUp
    {
        [Key]
        public int UserID { get; set; }
        
       
        [Required(ErrorMessage = "Email is required")]
        public string Email { get; set; }
  
        [Required(ErrorMessage ="Password Required"), DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage ="Password Required"), DataType(DataType.Password)]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }
    }

   
}
