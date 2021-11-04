using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebProductView.Models
{
    public class Product
    {
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Display(Name = "Code")]
        [Required(ErrorMessage = "The Code field is very important!")]
        public string productCode { get; set; }

        [Display(Name = "Description")]
        [Required]
        public string description { get; set; }

        [Display(Name = "Features")]
        public string features { get; set; }

        [Display(Name = "Stock")]
        [Required]
        public int stock { get; set; }

        [Display(Name = "Image")]
        public string image { get; set; }

        [Display(Name = "CategoryId")]
        public Category category { get; set; }

        [Display(Name = "SupplierId")]
        public Supplier supplier { get; set; }
    }
}
