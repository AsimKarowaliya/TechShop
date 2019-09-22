using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TechShop.Models
{
    public class Products
    {
        [Key]
        public int ProductId { get; set; }

        public string Name { get; set; }

        public string Cpu { get; set; }

        public string Gpu { get; set; }

        public string Ram { get; set; }

        public string Storage { get; set; }

        public decimal Price { get; set; }
    }
}
