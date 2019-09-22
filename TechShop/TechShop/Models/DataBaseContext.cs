﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TechShop.Models
{
    public class DataBaseContext: IdentityDbContext<ApplicationUser>
    { 
        public DataBaseContext(DbContextOptions<DataBaseContext> options): base(options)
        {

        }
        public new DbSet<SignUp> Users { get; set; }

        public DbSet<Products> Products { get; set; }
    }
}
