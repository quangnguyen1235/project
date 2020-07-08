using EmployeeManagement.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace EmployeeManagement.ViewModels
{
    public class HomeCreateViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "The name is required: Please input name.")]
        [Display(Name = "Name")]
        [MaxLength(20, ErrorMessage = "Can not exceed 20 characters.")]
        public string fullName { get; set; }
        [Required(ErrorMessage = "The email is required: Please input email")]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage = "Invallid email: Incorrect email format.")]
        [Display(Name = "Email")]
        public string email { get; set; }
        [Display(Name = "Department")]
        [Required(ErrorMessage = "Invallid department: Please choose the department.")]
        public Dept? departerment { get; set; }
        public IFormFile Image { get; set; }
    }
}
