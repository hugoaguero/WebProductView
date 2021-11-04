﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebProductView.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string name { get; set; }
        public List<Product> products { get; set; }
    }
}
