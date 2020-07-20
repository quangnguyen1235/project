using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagement1.Models
{
    public class Book
    {
        public int BookId { get; set; }
        [Required]
        [Display(Name ="Book name")]
        public string BookName { get; set; }
        [Required]
        [Display(Name = "Author")]
        public string BookAuthor { get; set; }
        [Required]
        [Display(Name = "ShortDesCription")]
        public string ShortDesCription { get; set; }
        [Required]
        [Display(Name = "Year")]
        public DateTime Year { get; set; }
        [Required]
        [RegularExpression(@"^[1-9]\d*$",
         ErrorMessage = "Invalid Qlt")]
        public int Qlt { get; set; }
        [Required]
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
