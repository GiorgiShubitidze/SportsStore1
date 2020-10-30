﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore
{
    public class Product
    {
        public  int ProductId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
        public ICollection<ProductPicture> ProductPicuture { get; set; }
        public ProductCategory ProductCategory { get; set; } 
    }
}
