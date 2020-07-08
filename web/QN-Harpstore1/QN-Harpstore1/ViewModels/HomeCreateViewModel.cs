using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QN_Harpstore1.ViewModels
{
    public class HomeCreateViewModel
    {
        [Required(ErrorMessage = "The Product Name is required: Please input name.")]
        [Display(Name = "Product Name")]
        [MaxLength(100, ErrorMessage = "Can not exceed 100 character.")]
        public string ProductName { get; set; }
        public string ShortDescription { get; set; }
        public string FullDescription { get; set; }
        public IFormFile Image { get; set; }
        [Required(ErrorMessage = "The Product Type is required: Please choose a product type")]
        [Display(Name = "Product Type")]
        public int ProductTypeId { get; set; }
        [Required(ErrorMessage = "The Producer is required: Please choose a producer")]
        [Display(Name = "Producer")]
        public int ProducerId { get; set; }
        //public bool IsUsed { get; set; }
        [Required(ErrorMessage = "The Price is required: Please input price")]
        [RegularExpression(@"^([.]|[0-9])[0-9]*[.]*[0-9]+$", ErrorMessage = "Invallid price")]
        public float ProductPrice { get; set; }
    }
}
