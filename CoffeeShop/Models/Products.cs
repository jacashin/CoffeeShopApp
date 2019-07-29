using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeShop.Data
{
    public class Product
    {
        [Key]
        public string FlavorName { get; set; }

        public string Roast { get; set; }
        public int Size { get; set; }
    }
}