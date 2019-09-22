using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TechShop.Models
{
    public class ApplicationUser: IdentityUser
    {
        public string Address1 { get; set; }
    }
}
